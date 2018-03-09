# Spa ASMR 2018


## Summary

This is my third attempt to build a directory of ASMR videos.  I had built two others as Angular apps.  This one will be built via .NET MVC 5 on top of a SQL Server database, performing most of the logic on the server side.  

## Technologies ( so far )

+ .NET MVC 5
+ SQL Server 
+ Entity Framework
+ Visual Studio
+ git (gitHub)
+ LINQ

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


## Screenshot

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


## Credit

I for real need a job :) 

ISO junior to mid dev position in the Los Angeles area.  My strength is C# fundamentals and I'm getting better daily with MVC.  I've deployed apps to Azure, Heroku, and AWS with Angular and AngularJS front-ends, but I intend to relearn vanilla JavaScript from the ground-up, just as I have C#.  Please check out my LinkedIn: 

[LinkedIn](https://www.linkedin.com/in/sbogucki12/ "Steve's LinkedIn Profile")

Email: sbogucki@mail.usf.edu

![Imgur](https://i.imgur.com/O0Hxg8b.jpg)


**Go Birds**


