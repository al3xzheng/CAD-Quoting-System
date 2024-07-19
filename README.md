This application is meant to be a quoting software for CAD files, starting off with SolidWorks projects, and then potentially adding AutoCAD, and potentially Altium Designer. 

A .NET application written in C#, this application uses COM Interop to install an Add-In in SolidWorks. Conveniently, the UI of the SolidWorks Add-In will be configured by .NET Windows Forms (User Control).
This UI allows you the select a file to be quote and will display the quoted price for such a design.

The SolidWorks API is gracefully used to access a SolidWorks file's properties (material, surface area, edges, corners, etc.) in order to accurately quote.

The basis for quoting is based on the price to do CNC (Computer Numerical Control) manufacturing on said SolidWorks part/assembly. 
This serves as an accurate quoting software that allows for an automated client-pricing program for mechanical manufacturers.

The quoting algorithm can be abtained from obtained CNC manufacturing data and building an 'AI model' that will build regression models which our data can map to!

This project is not finished and is currently in the works. Feel free to connect and message me on LinkedIn to know more about it or for a chat on anything! @ https://www.linkedin.com/in/al3xzheng/ 
