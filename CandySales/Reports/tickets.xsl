<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/tickets">
    <html>
      <body>
        <style>
          body {
          font-family: "Segoe UI", Frutiger, "Frutiger Linotype", "Dejavu Sans", "Helvetica Neue", Arial, sans-serif;
          }
          #name-region {
            border-bottom: 1px solid black
          }
        </style>
        <div id="report">
          <table width="100%" style="border-collapse: collapse">
            <xsl:apply-templates select="./ticket">
            </xsl:apply-templates>
          </table>
        </div>
      </body>
    </html>
  </xsl:template>
  <xsl:template match="record">
    <tr>
      <xsl:apply-templates select="./ticket"></xsl:apply-templates>
    </tr>
  </xsl:template>
  <xsl:template match="ticket">
    <td>
      <div id="name-region">
        <h3>
          <xsl:value-of select="name"/>
        </h3>
      </div>
      <p>
        <xsl:value-of select="shop"/>
      </p>
      <p>
        <xsl:value-of select="grade"/>
      </p>
    </td>
  </xsl:template>
</xsl:stylesheet>
