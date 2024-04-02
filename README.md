CAD Packet Builder
The CAD Packet Builder is designed to streamline the process of generating new CAD packets for walk-in configurations based on pre-engineered designs, specifically tailored for chain customers or standard configurations. By automatically incorporating a new Sales Order into an existing CAD packet, this tool aims to simplify and speed up the customization process.

Adding New Configurations
To extend the CAD Packet Builder with new configurations, follow these steps:

Create Configuration Folder: Navigate to R:\Documents\Packet Generator\Configurations\ and create a new folder named after the configuration you're adding.

Smart PDF Packet: Place a "Smart PDF packet" inside the newly created folder. The PDF should be named identically to its parent folder (e.g., if the folder is named 123456, the PDF should be 123456.pdf). This PDF should have text fields labeled SALESORDER where the sales order number will be automatically inserted. Make sure to add these text boxes in the appropriate locations within the PDF before proceeding.

Panel Builder Review Workbook: Add a completed "Panel Builder Review" Excel workbook (.xlsx format) to the same folder where the PDF resides. This document should contain the necessary details for building the configuration.The code works by putting the Sales order in cell Z1 and formulas in the excel sheet should populate the sales order from there. (you need to add these formuals yourself)

Floor Plan Image: Place a PNG image of the wall floor plan in R:\Documents\Packet Generator\Images\. The image file should have the same name as your configuration folder and PDF (e.g., 123456.png).

Important Note:
The CAD Packet Builder identifies where to insert the sales order in the PDF by looking for text fields named SALESORDER. Ensure these fields are correctly named and positioned in your Smart PDF Packet prior to including it in your configuration folder.

By following these steps, you can efficiently add new configurations to the CAD Packet Builder, making it a versatile tool for quickly generating customized CAD packets for your sales orders.
