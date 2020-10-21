# ASP.NET.MVC
 This Repo contains ASP.NET MVC study notes & code



# 1. What is MVC?

a. MVC stands for Model-View-Controller

b. MVC is an architectural/design pattern.

c. Used to achieve separation of concerns.

d. Used for Web, Mobile applications.



# 2. What is ASP.NET MVC?

a. It is a .NET Framework that follows MVC design pattern.

b. It is used for web development.

c. It provide all the tools required to create an MVC web application.



# 3. Tools required 	

1. .NET Framework (Latest version is 4.8)
2. Visual Studio (Latest version is 2019)



# 4. MVC Folder Structure

1. **Models**

   We put all **model** classes in this folder.

2. **Views**

   We put all **views** in this folder. Shared folder is also there consists of ***_Layout.cshtml*** file.

3. **Controllers**

   We put all **controller** classes in this folder

4. **Scripts**

   We put all **JavaScript** files in this folder

5. **fonts**

   We put all web **fonts** in this folder

6. **App_Data**

   All the data required for read/write into application. **JSON**/**XML**

7. **App_Start**

   We put all configuration files in this folder. **RouteConfig**, BundleConfig etc

8. **Content**

   We put **static** data in this folder like **css** & **images**



# 5. MVC File Structure

1. **Favicon.ico**

   Website icon

   

2. **Global.asax**

   a. This file consists a function ***Application_Start()*** that'll be called first whenever our application starts.

   b. We register all our configuration in this method like:

   ​	a. **Area Registration**

   ​	b. **Filter Configuration** 

   ```c#
   FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);	
   ```

   ​	c. **Route Configuration**

   ```c#
   RouteConfig.RegisterRoutes(RouteTable.Routes);
   ```

   ​	d. **Bundle Configuration**

   ```c#
   BundleConfig.RegistedBundles(BundleTable.Bundles);
   ```

   

3. **Packages.config**

   This file contains all the installed packages with their version info (MVC 5, JQuery, Bootstrap etc)

   

4. **Web.Config**

   All application level configuration settings are added in this file. (Connection Strings, Form Authentication, Custom Error Pages etc)



5. **References**

   All used DLLs are in this folder



# 6. Controllers



1. Controller is a C# class (.cs file) that inherits from "**Controller**" base class.
2. It is used to handle **requests** from client and then send the appropriate **response** back.
3. Controller classes are put into Controllers folder.



# 7. View

1. It is the front end of an MVC application
2. View is a .cshtml file (c# in html)
3. View supports pure HTML.
4. Views are returned either as **ActionResult**, **IActionResult** or **ViewResult**