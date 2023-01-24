# Car sales/rental website application (ArabaSizin) with ASP.NET MVC5

## ArabaSizin Api Addresses

If we want to start the project with [Microsoft Visual Studio](https://visualstudio.microsoft.com/), we start the project by right-clicking on the "[\Views\Home\Index.cshtml](https://github.com/AtakanTurgut/arabasizin/blob/main/arabaSizin/Views/Home/Index.cshtml/)" file while the project is open and selecting "View in Browser ([Selected Browser](https://www.google.com.tr/))".

If we want, we can also use `\Index.cshtml` of other "[\Views](https://github.com/AtakanTurgut/arabasizin/tree/main/arabaSizin/Views/)" files to see how other pages look.

However, it's best to start the project with "[\Views\Home\Index.cshtml](https://github.com/AtakanTurgut/arabasizin/blob/main/arabaSizin/Views/Home/Index.cshtml/)" to run it properly.

The application also has an admin panel. Admin can add, delete, update, see all car list.

Use this user name and password for the admin page.

                UserName : atakanturgut
                Password : 123456

The project runs on "[localhost:?/](https://localhost:44361/)".

## Used Packages

- Some packages can be installed from the "[NuGet Gallery](https://www.nuget.org/packages/Microsoft.AspNet.Identity.Core)" with the help of the `Tools > NuGet Package Manager > Package Manager Console`.

- [EntityFramework 6.4.4](https://www.nuget.org/packages/EntityFramework/)
```
    PM>  NuGet\Install-Package EntityFramework -Version 6.4.4
```
- [Microsoft.AspNet.Identity.Core 2.2.3](https://www.nuget.org/packages/Microsoft.AspNet.Identity.Core)
```
    PM>  NuGet\Install-Package Microsoft.AspNet.Identity.Core -Version 2.2.3
```
- [Microsoft.AspNet.Identity.Owin 2.2.3](https://www.nuget.org/packages/Microsoft.AspNet.Identity.Owin/)
```
    PM>  NuGet\Install-Package Microsoft.AspNet.Identity.Owin -Version 2.2.3
```
- [Microsoft.AspNet.Identity.EntityFramework 2.2.3](https://www.nuget.org/packages/Microsoft.AspNet.Identity.EntityFramework/)
```
    PM>  NuGet\Install-Package Microsoft.AspNet.Identity.EntityFramework -Version 2.2.3
```
- [Microsoft.Owin.Host.SystemWeb 4.2.2](https://www.nuget.org/packages/Microsoft.Owin.Host.SystemWeb)
```
    PM>  NuGet\Install-Package Microsoft.Owin.Host.SystemWeb -Version 4.2.2
```
- [PagedList.Mvc 4.5.0](https://www.nuget.org/packages/PagedList.Mvc)
```
    PM>  NuGet\Install-Package PagedList.Mvc -Version 4.5.0
```

- [ ] If you get an error like this in the console with F12 (It may be due to the version.):

                Uncaught ReferenceError: $ is not defined at ?

- [ ] Go to the project directory you want to install with `Command Prompt (CMD)` and install [jQuery](https://jquery.com/download/).
```
    npm install jquery
```

- [ ] Use this script before the script you are writing [[source]](https://stackoverflow.com/questions/2075337/uncaught-referenceerror-is-not-defined):
```html
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>

    For Example:

    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#markaId").change(function () {
                var sehirId = $(this).val();
                debugger
                $.ajax({
                    type: "Post",
                    url: "/Ilan/ModelGetir?markaId=" + sehirId,
                    contentType: "html",
                    success: function (response) {
                        debugger
                        $("#modelId").empty();
                        $("#modelId").append(response);
                    }
                })
            })
        })
    </script>
```

----
## ArabaSizin Project [Images](//)

### 1. Home Page:  https://localhost:44361/Home/Index
![](/pictures/HomePage1.PNG)
![](/pictures/HomePage2.PNG)

### 2. Register Page:  https://localhost:44361/Account/Register
![](/pictures/RegisterPage.PNG)

### 3. Login Page:  https://localhost:44361/Account/Login
![](/pictures/LoginPage.PNG)

### 4. Admin Page:  https://localhost:44361/Admin/Index
![](/pictures/AdminPage.PNG)

### 5. Advert Create Page:  https://localhost:44361/Ilan/Create
![](/pictures/AdvertCreatePage.PNG)

### 6. Profile Page:  https://localhost:44361/Account/Profil
![](/pictures/ProfilePage.PNG)

### 7. User Advert List:  https://localhost:44361/Ilan/Index
![](/pictures/AdvertListPage.PNG)

### 8. Add Picture for Advert Page:  https://localhost:44361/Ilan/Images/12
![](/pictures/AddPictureforAdvertPage.PNG)
