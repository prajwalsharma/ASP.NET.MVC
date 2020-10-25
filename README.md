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



# 8. Model

1. A Model is a C# class
2. Model is responsible to hold data (variables & properties)
3. Data coming from DB is stored in Models (in memory) then this data is sent to View.



# 9. ViewBag

1. It is used to send data from Controller to View

2. It is a ***dynamic*** property.

   ```c#
   // In Controller
   ViewBag.MyProperty = "Hello World";
   
   // In View
   @ViewBag.MyProperty
   ```



# 10. ViewData

1. It is also used to pass data from Controller to View only

2. It is of ***Dictionary*** type

   ```c#
   //In Controller
   ViewData["MyProperty"] = "Hello World";
   ```



# 11. Difference between ViewData & ViewBag

1. ViewBag is of dynamic type, ViewData is of dictionary type
2. ViewData requires type-casting for complex data types, ViewData does not require type casting.



# 12. TempData

1. Used to send pass data from one request to another request.

2. ViewBag & ViewData lost their values after 1 request therefore we cannot use it to show alerts.

3. TempData can store data only up to next 1 request.

4. TempData implements ***Session*** internally. If session is disabled then it won't work.

   ```c#
   // Keep Method - Keep the data for next request
   TempData["MyKey"] = "Hello World";
   TempData.Keep();
       
   // Peek() Method - Keep the data for next request in one line
   ViewBag.MyKey = TempData.Peek("MyKey");
   ```



# 13. HTTP 

1. HTTP is Hyper Text Transfer Protocol.
2. This protocol (set of rules) provide communication between client & server.
3. HTTP provide some methods (verbs) for the actions performed on the resource.
4. Every action method is by default ***GET***
   1. **GET**	(Data will be sent in the URL)
   2. **POST** (Data will be sent in Request Body)
   3. **PUT**
   4. **DELETE**



# 14. Routing

1. Routing is a feature of ASP.NET that maps the incoming URL to the controller & action Methods.

2. It is a pattern matching system.

3. When our application starts, it stores all the created routes in a route table.

4. **Route Table**

   a. We create route for each action method

   b. All the routes are stored in route table

   c. Each incoming request is mapped to this route table.

   d. If any matching URL found, then request goes to the controller.

   e. If not found, then 404 not found response is send back to the client.

5. There are 2 type of routing:

   ​	a. **Traditional Routing** (MVC 4 & below)

   ​	b. **Attribute Routing** (MVC 5)

   

# 15. Traditional Routing

1. We create all routes in ***RouteConfig*** file.
2. RouteConfig file is in **App_Start** folder.
3. Each route need to be registered to make them work.
4. Route has 4 parameters:
   1. **Name**
   2. **Pattern**
   3. **Default Values**
   4. **Constraints**

