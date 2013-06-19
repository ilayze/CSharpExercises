using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace XmlParserTool
{
    public class TransformBL
    {
        private string space = "";
        List<MethodInfo> getAndSetMethods=new List<MethodInfo>();
        public static string ErrorMessage = "";
        internal string javaClassName;
        internal const string xslPath = @"D:\שנה ג\תכנות בסביבת אינטרנט\תרגילים סמסטר\תרגיל 4\XmlParserTool\XmlParserTool\ClassTransform.xslt";

        public bool CreateAPI(string xmlFile,string outputFolder)
        {
            
            try
            {
                string outputFile;
                string[] splited = xmlFile.Split('\\');
                string fileName = splited[splited.Length - 1];
                fileName = fileName.Substring(0, fileName.Length - 3) + "html";
                outputFile = outputFolder +"\\"+ fileName;

                CreateClassFromXML(xmlFile, outputFolder);
                XPathDocument xml = new XPathDocument(xmlFile);
                XslCompiledTransform trans = new XslCompiledTransform();
                trans.Load(xslPath);
                XmlTextWriter output = new XmlTextWriter(outputFile, null);
                trans.Transform(xml, null, output);
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
                return false;

            }
          

            return true;

        }

        #region CreateClassFromXML
       
        public bool CreateClassFromXML(string xmlFile, string outputFolder)
        {
            if (!xmlFile.EndsWith(".xml"))
                return false;
           
            XmlDocument dom = new XmlDocument();

            try
            {

                 dom.Load(xmlFile);

                 XmlNode classNode=dom.SelectSingleNode("Class");
                 if (classNode == null)
                 {
                     ErrorMessage="No class tag in xml file";
                     return false;
                 }

                XmlAttribute xmlAttribute = classNode.Attributes["name"];
                if (xmlAttribute == null)
                {
                    ErrorMessage = "Missed attribute name to class tag!";
                    return false;
                }
                string className = xmlAttribute.Value;
                javaClassName = className;
                FileStream fileStream = File.Create(Path.Combine(outputFolder, className+".java"));
                StreamWriter writer=new StreamWriter(fileStream);

                writer.WriteLine(space+"public class "+className);
                writer.WriteLine(space+"{");
                writer.WriteLine();
                writer.WriteLine();

                IncreaseSpace();
                try
                {
                    ParseAttributes(dom, writer);
                    ParseConstructors(dom, writer);
                    ParseMethods(dom, writer);
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    return false;
                }
      
                DecreaseSpace();
                writer.WriteLine(space+"}");
                writer.Flush();
                writer.Close();
                fileStream.Close();

            }
            catch (XmlException e)
            {
                ErrorMessage = e.Message;
                return false;
            }
            
            return true;
        }
        #endregion

        #region ParseMethods

        private void ParseMethods(XmlDocument dom, StreamWriter writer)
        {
            //generate gets and sets
            foreach (var methodinfo in getAndSetMethods)
            {
                //get method
                if (methodinfo.MethodType == MethodType.Get)
                {
                    string getString = "public "+methodinfo.Type+" get"+methodinfo.methodName+"()";
                    writer.WriteLine(space+getString);
                    writer.WriteLine(space+"{");
                    writer.WriteLine(space+space+"return "+methodinfo.methodName+";");
                    writer.WriteLine(space+"}");


                }
                //set method
                else
                {
                    string setString = "public void set" + methodinfo.methodName + "(" + methodinfo.Type + " " +
                                       methodinfo.methodName+")";
                    writer.WriteLine(space+setString);
                    writer.WriteLine(space+"{");
                    writer.WriteLine(space+space+"this."+methodinfo.methodName+"="+methodinfo.methodName+";");
                    writer.WriteLine(space+"}");
                }
            }

            //methods
            XmlNodeList methodsListnodes = dom.SelectNodes("Class/Methods/Method");

            if (methodsListnodes == null)
                return;
            
            for (int i = 0; i < methodsListnodes.Count; i++)
            {
                XmlNode methodNode = methodsListnodes[i];

                string methodName = methodNode.SelectSingleNode("Name").InnerText;
                string accessModifier = methodNode.SelectSingleNode("AccMod").InnerText;
                string returnVal=methodNode.SelectSingleNode("Return").InnerText;

                var parameterList = generateParameters(methodNode);

                 string parametersString = "";
                foreach (var parameterInfo in parameterList)
                {
                    parametersString += parameterInfo.Type + " " + parameterInfo.Name+",";
                }

                if(parametersString.EndsWith(","))
                    parametersString = parametersString.Substring(0, parametersString.Length - 1);

                string methodString = accessModifier + " " + returnVal + " " + methodName + "(" + parametersString + ")";
                writer.WriteLine(space+methodString);
                writer.WriteLine(space+"{");

                string valueToReturn;
                if (returnVal != "void")
                {
                    switch (returnVal)
                    {
                        case "int":
                            valueToReturn = "0";
                            break;
                        case "double":
                            valueToReturn = "0";
                            break;
                        case "String":
                            valueToReturn = "";
                            break;
                        case "boolean":
                            valueToReturn = "false";
                            break;
                        default:
                            valueToReturn = "null";
                            break;

                    }

                    writer.WriteLine(space+space+"return "+valueToReturn);
                }

                writer.WriteLine(space+"}");


            }
        }
        #endregion

        #region ParseConstructors

        private void ParseConstructors(XmlDocument dom, StreamWriter writer)
        {
            XmlNodeList constructorsList = dom.SelectNodes("Class/Constructors/Constructor");
            if (constructorsList == null)
                return;
            for (int i = 0; i < constructorsList.Count; i++)
            {
                XmlNode constructorNode = constructorsList[i];

                IEnumerable<ParameterInfo> parameters = generateParameters(constructorNode);

                string parametersString = "";
                foreach (var parameterInfo in parameters)
                {
                    parametersString += parameterInfo.Type + " " + parameterInfo.Name+",";
                }

                if (parametersString.EndsWith(","))
                {
                    parametersString = parametersString.Substring(0, parametersString.Length - 1);
                }

                string constructorString = "public " + javaClassName + "(" + parametersString + ")";
                writer.WriteLine(space+constructorString);
                writer.WriteLine(space+"{");
                writer.WriteLine(space+"}");

            }
        }

        private IEnumerable<ParameterInfo> generateParameters(XmlNode node)
        {
            var parameterList = node.SelectNodes("Parameters/Parameter");
            if (parameterList == null)  //empty constructor
            {
                return null;
            }

            var parameters = new List<ParameterInfo>();
            foreach (XmlNode parameter in parameterList)
            {
                string name = parameter.SelectSingleNode("Name").InnerText;
                string type = parameter.SelectSingleNode("Type").InnerText;
                parameters.Add(new ParameterInfo
                {
                    Name = name,
                    Type = type
                });
            }
            return parameters;
        }

        #endregion

        #region ParseAttributes
       
        private void ParseAttributes(XmlDocument dom, StreamWriter writer)
        {
            XmlNodeList attributesList = dom.SelectNodes("Class/Attributes/Attribute");
           if (attributesList == null)
               return;
           for (int i = 0; i < attributesList.Count; i++)
           {
               XmlNode node = attributesList[i];

               if (node.Attributes == null)
                   return;
                
               string final = node.Attributes["final"].Value;
               string get = node.Attributes["get"].Value;
               string set = node.Attributes["set"].Value;

               XmlNodeList childNodes = node.ChildNodes;

               string name = null;
               string type = null;
               string access = null;
               for (int j = 0; j < childNodes.Count; j++)
               {
                   

                   if (childNodes[j].Name == "Name")
                   {
                       name = childNodes[j].InnerText;
                   }
                   else if (childNodes[j].Name == "Type")
                   {
                       type = childNodes[j].InnerText;
                   }
                   else if (childNodes[j].Name == "AccMod")
                   {
                       access = childNodes[j].InnerText;
                   }
                   else
                   {
                       throw new Exception("Invalid tag in attributes");
                   }
               }

               if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(type) || String.IsNullOrEmpty(access))
               {
                   throw new Exception("Inavalid Attribute");
               }
               if(final.Equals("yes"))
               {
                   final = " final ";
               }
               else
               {
                   final = " ";
               }

               writer.WriteLine(space+access+final+type+" "+name+";");

               if (get == "yes")
               {
                   MethodInfo getMethod = new MethodInfo
                                              {
                                                  MethodType = MethodType.Get,methodName = name,Type = type
                                              };
                   getAndSetMethods.Add(getMethod);
               }

               if (set == "yes")
               {
                   MethodInfo setMethod = new MethodInfo
                                              {
                                                  MethodType =MethodType.Set,methodName = name,Type = type
                                              };
                   getAndSetMethods.Add(setMethod);
               }

           }
           writer.WriteLine();    

        }

        #endregion

        #region Private Methods and classes
       
        private void IncreaseSpace()
        {
            space += "\t";
        }

        private void DecreaseSpace()
        {
            space =space.Substring(1);
        }

        private class MethodInfo
        {
            public MethodType MethodType { get; set; }
            public string Type { get; set; }
            public string methodName { get; set; }
           
        }

        private class ParameterInfo
        {
            public string Name { get; set; }
            public string Type { get; set; }
            
        }

        enum MethodType
        {
            Get,
            Set
        }

        #endregion
    }
        




}
