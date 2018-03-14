# Spa ASMR 2018

![Recordit](http://g.recordit.co/UHGv3HCm1j.gif)

![Imgur](https://i.imgur.com/oNhUG0Q.jpg)

![Imgur](https://i.imgur.com/XDtGqcc.jpg)

## Summary

This is my third attempt to build a directory of ASMR videos.  I had built two others as Angular apps.  This one will be built via .NET MVC 5 on top of a SQL Server database, performing most of the logic on the server side.  

## Technologies ( so far )

+ .NET MVC 5
+ SQL Server 
+ Entity Framework
+ Visual Studio
+ git (gitHub)
+ LINQ
+ jQuery
+ OAuth

## Timeline

**Day One (March 7, 2018) AM:** 
+ Created Artist, Video, Video Genre data models.
+ Connected to SQL Server Express. 
+ Used migration to create SQL Server database.
+ Seeded these tables via migrations: VideoGenres, Artists, Videos (for Artists: Gibi, GentleWhispering, ASMRRequests, ASMR Glow, and Heather Feather).

**Day One (March 7, 2018) PM**
+ Created controller, view, viewmodel for videos index page to test and confirm that data is transferring. Success. 

**Day Two (March 8, 2018)**
+ Added a ArtistName column to the Videos table via migration. 
+ Added "ASMRrequest" name to the column in the table for rows containing her videos. 
+ Created a rough, preliminary artist page, accessible  by query string. 

**Day Three (March 9, 2018)**
+ Used an EF migration to add video genres to Videos table via sql commands. 
+ Added a views to get videos by genre, and then one to get my gender and genre. 

**Day Four (March 10, 2018)**
+ Sorted videos view now displays via table with links to watch videos.
+ Created a very rough draft homepage.  
+ Fixed the forms on the front page, made an error page, hooked up controllers.  Basic functionality is successful!

**Day Five (March 12, 2018)**
+ Updated primary videos view to use a jQuery DataTable.
+ Added authentication using Microsoft Identity (which, btw, is way harder when you don't do it from project initiation!).
+ Added ability to log-in via facebook (OAuth).

**Day Six (March 13, 2018)**
+ Using probably more effort than necessary, created a web API for added videos to a User's List of Favorites. 

**Day Seven (March 14, 2018)**
+ Added properties to the ApplicationUser class. 
+ Updated AspNetUsers table using Alter Table command in SQL Server Management Studio.
+ Added an action method in favorites controllert to add videos to user's profile. 
+ Rearranged the navigation. Clicking on username now goes to favorite videos with link there to account details. 
+ Updated main page styling. 

## Credit

I for real need a job :) 

ISO junior to mid dev position in the Los Angeles area.  My strength is C# fundamentals and I'm getting better daily with MVC.  I've deployed apps to Azure, Heroku, and AWS with Angular and AngularJS front-ends, but I intend to relearn vanilla JavaScript from the ground-up, just as I have C#.  Please check out my LinkedIn: 

[LinkedIn](https://www.linkedin.com/in/sbogucki12/ "Steve's LinkedIn Profile")

Email: sbogucki@mail.usf.edu


## Screenshots

+ Day One (March 7, 2018):

*This is an example of one of the simple data models:*

![Imgur](https://i.imgur.com/qNvPmum.jpg)

*This is the SQL Server database currently:*

![Imgur](https://i.imgur.com/PxO7p9C.jpg)

*This is the VideoGenres table with seeded data:*

![Imgur](https://i.imgur.com/z5AIzNm.jpg)

*This is how I seed data:*

![Imgur](https://i.imgur.com/R7IHYJW.jpg)

*This is the videos index page for testing purposes:*

![Imgur](https://i.imgur.com/UnrnJvN.jpg)


+ Day Two (March 8, 2018): 

*This is the preliminary code for selecting an individual artist's page:*

![Imgur](https://i.imgur.com/CpqiBwe.jpg)

*This is the first draft of an artist page:*

![Imgur](https://i.imgur.com/EYvN6Gl.jpg)



+ Day Three (March 9, 2018)

*Videos are now sorted by genre*

![Imgur](https://i.imgur.com/wuakIIl.jpg)

*Videos sorted by genre and gender* 

![Imgur](https://i.imgur.com/eWOIa5q.jpg)


+ Day Four (March 10, 2018)

*Updated the Videos table via Sql in an EF migration:*

![Imgur](https://i.imgur.com/ASb5bJt.jpg)

*Sorted videos now displayed on table with links to watch videos*

![Imgur](https://i.imgur.com/Tp0S3PB.jpg)

*Super rough draft, preliminary home page*

![Imgur](https://i.imgur.com/YfZ821L.jpg)


+ Day Five (March 12, 2018)

*We now have user authentication:*

![Imgur](https://i.imgur.com/MLVzd8A.jpg)

*Facebook log-in*

![Imgur](https://i.imgur.com/xzs3lYy.jpg)


+ Day Seven (March 14, 2018):

*Now have code to save videos to user profile:*

![Imgur](https://i.imgur.com/tSwMkZj.jpg)



**Go Birds**

![Imgur](https://i.imgur.com/O0Hxg8b.jpg)








