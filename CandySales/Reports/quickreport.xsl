<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/quickreport">
		<html>
			<body>
        <style>
            body {
              font-family: "Segoe UI", Frutiger, "Frutiger Linotype", "Dejavu Sans", "Helvetica Neue", Arial, sans-serif;
            }
            th{
              border-bottom: 2px solid black;
              border-top: 2px solid black;
              padding: 15px;
            }
        </style>
				<div id="report">
					<div id="header">
						<h1>Candy Sales Quick Report</h1>
            <h4><xsl:value-of select="queryTerms"/></h4>
					</div>
					<div id="content">
						<table width="100%" style="border-collapse: collapse">
							<tr>
								<th>Name</th>
								<th>Shop</th>
                <th>Grade</th>
								<th>Outstanding Orders</th>
								<th>Debt</th>
							</tr>
            		<xsl:apply-templates select="./record">
						    </xsl:apply-templates>
						</table>
					</div>
				</div>
			</body>
		</html>
	</xsl:template>
	<xsl:template match="record">
		<tr>
			<td style="text-align: left; border-bottom: 1px solid black; padding: 10px;">
        <p>
          <xsl:value-of select="name"/>
        </p>
      </td>
			<td style="text-align: left; border-bottom: 1px solid black; padding: 10px;">
        <p>
          <xsl:value-of select="shop"/>
        </p>
      </td>
      <td style="text-align: center; border-bottom: 1px solid black; padding: 10px;">
        <p>
          <xsl:value-of select="grade"/>
        </p>
      </td>
			<td style="text-align: center; border-bottom: 1px solid black; padding: 10px;">
        <p>
          <xsl:value-of select="outstanding-orders"/>
        </p>
      </td>
			<td style="text-align: center; border-bottom: 1px solid black; padding: 10px;">
        <p>
          <xsl:value-of select="debt"/>
        </p>
      </td>
		</tr>
	</xsl:template>
</xsl:stylesheet>