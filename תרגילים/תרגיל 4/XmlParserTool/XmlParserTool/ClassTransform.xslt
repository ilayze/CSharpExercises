<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/">
      <html >
        <head>
          
        </head>
        <body>
          <h2>
            Class Name: <xsl:value-of select="Class/@name"/>
          </h2>
          <br/>
          <h2>
            Attributes
          </h2>
          <p>
            <xsl:for-each select="Class/Attributes/Attribute">

              <p>Access Modifier: <xsl:value-of select="AccMod"/> |
                Type: <xsl:value-of select="Type"/> |
                Is Const: <xsl:value-of select="@final"/> |
                Name: <xsl:value-of select="Name"/>
            </p>
            </xsl:for-each>
          </p>
          <br/>
          <h2>
            Constructors
          </h2>
          <p>
            <xsl:for-each select="Class/Constructors/Constructor">
              <p>
                Constructor Name:<xsl:value-of select="/Class/@name"/>  |
                Parameters: <xsl:for-each select="Parameters/Parameter">
                  <xsl:value-of select="Type"/>&#160;<xsl:value-of select="Name"/>  ,
                </xsl:for-each>
              </p>
            </xsl:for-each>
          </p>
          <br/>
          <h2>
            Methods
          </h2>
          <p>
            <xsl:for-each select="Class/Methods/Method">
              <p>
                Access Modifier: <xsl:value-of select="AccMod"/> | Return Value: <xsl:value-of select="Return"/>
                 | Name: <xsl:value-of select="Name"/> | Parameters: 
                 <xsl:for-each select="Parameters/Parameter">
                <xsl:value-of select="Type"/>&#160;<xsl:value-of select="Name"/>  ,
              </xsl:for-each>
              </p>
            </xsl:for-each>
          </p>
          
          
        </body>
      </html>
      
    </xsl:template>
</xsl:stylesheet>
