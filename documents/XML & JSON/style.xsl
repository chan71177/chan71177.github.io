<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:p="http://southcentral.edu/ns/chandra/mkproduct">

    <xsl:template match="/">
    <html>
    <body>
        <h1>List of Mary Kay Product</h1>
        <ul>
        <xsl:for-each select="p:products/p:product">
            <li><xsl:value-of select="p:type"/>  -Specifically-  <xsl:value-of select="p:color"/></li>   
        </xsl:for-each>
        </ul>
    </body>
    </html>
    </xsl:template>

</xsl:stylesheet>
