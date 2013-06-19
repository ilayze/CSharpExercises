<xsl:stylesheet 
      xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
      version="1.0">

<!-- indicates what our output type is going to be -->
<xsl:output method="text" />		
	

<xsl:template match="/">
	
 <xsl:value-of select="/CV/Name"/><xsl:text>&#13;&#10;</xsl:text>
Birth Date: <xsl:value-of select = "/CV/Birth" /> <xsl:text>&#13;&#10;</xsl:text>
Address: <xsl:value-of select = "/CV/Address" /><xsl:text>&#13;&#10;</xsl:text>
Former experience: <xsl:text>&#13;&#10;</xsl:text>
<xsl:for-each select = "/CV/Experience/Exp" >
	<xsl:if value = "IDF">
		Name: <xsl:value-of select = "@name"/> From: <xsl:value-of select = "@from"/>
		To: <xsl:value-of select = "@to"/><xsl:text>&#13;&#10;</xsl:text>
	</xsl:if>

</xsl:for-each>			
</xsl:template>

</xsl:stylesheet>
