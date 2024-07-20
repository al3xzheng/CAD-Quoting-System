This application is meant to be a **quoting software for CAD files**, starting off with **SolidWorks** projects, and then potentially adding **AutoCAD**, and potentially **Altium Designer**. It acts a quoting system. For the inital SolidWorks files, it would provide **the price to 3d-print** said solidworks file. The **quoting pricing algorithm** would be set up from **empirical data**. This initial ata which can be fairly easy to obtain by simply 3d-printing some parts and recording the price.

A **.NET** application written in **C#**, this application uses **COM Interop.** to install an **Add-In** in SolidWorks. Conveniently, the UI of the SolidWorks Add-In will be built as a **.NET Windows Forms User Control**.

Below is a demo pic of the basis of our application:
![image](https://github.com/user-attachments/assets/c147be8c-86b3-4641-bf24-d22412d0a858)

This UI allows you the select a file to be quote and will display the quoted price for the inputted file's design.

The **SolidWorks API** is gracefully used to access a SolidWorks file's _properties_ (material, surface area, edges, corners, etc.) in order to accurately quote.

As I mentioned above, the basis for quoting is based on the price to 3D-print said SolidWorks part/assembly. For _AutoCAD_ files, it may be to _laser cut_ ; For _Altium_ files, it may be the _manufacturing price_, although I believe this is already provided.

This serves as an accurate quoting software that allows for an **automated client-pricing program** for _mechanical, civil, and electrical engineers_ once fully developed.

The quoting algorithm can be obtained from _previous 3D-printing data_ and feeding the previously priced SolidWorks part/assembly into our application to get the data on how a part's certain property affects the price. This data can be obtained by clients who use this application, and by **initially test printing various types of parts** to generate initial data on the correlation between a part's properties and the price. Then we can build an **AI model** with **regression models** that accurately maps and weighs **how each property affects the difficulty to 3D-print**, and thus the price.

In conclusion, we can input a SolidWorks part/assembly and get a quote! And after a part is 3D-printed we can **correct and fine-tune the model with the true 3D-printing price**; therefore making
the software improve with every use and very smart.

This project is not finished and is currently in the works. Feel free to connect and message me on LinkedIn to know more about it or for a chat on anything! @ **https://www.linkedin.com/in/al3xzheng/**

In the future, to expand industry use, we will add the feature to quote **CNC (Computer Numerical Control) manufacturing**. This ability will greatly increase _industry_ value of this software instead of the current value from just _hobbyists_, which it aims to serve initially right now.
