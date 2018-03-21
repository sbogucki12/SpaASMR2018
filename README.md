# Spa ASMR 2018


![RecordIt](http://g.recordit.co/G2iP7h9FCd.gif)

![Imgur](https://i.imgur.com/XDtGqcc.jpg)


## Summary

A .NET MVC directory of ASMR youtube videos, allowing the user to choose videos per their preferences and save/remove videos to/from their list of favorite videos.  

## Technologies ( so far )

+ .NET MVC 5
+ SQL Server 
+ Entity Framework
+ Visual Studio
+ git (gitHub)
+ LINQ
+ jQuery
+ OAuth
+ Microsoft Identity Framework
+ Ajax
+ NLog
+ toastr

## To Do Next: 

[ X ] - Add button to remove video from Favorites.

[ X ] - Upgrade "Saved to Favorites"/"Remove Video" from alerts to bootboxes.

[ X ] - Create a form for users to submit errors they discover in the app.

[ X ] - Add an "About ASMR" section. 

[  ] - Add Video Length as a preference for users to choose.  

[ X ] - Add "Beta" to all instances of "Spa: ASMR".

[ ] - Add individual ASMRist Pages.

[ X ] - Make Login button conditional.

[ ] - Adjust CSS for mobile viewing 

[ ] - Refactor as needed, add comments, ensure error-handling is implemented where needed. 

----- [ ] - Create DTOs, use DTOs in APIs.

[ ] - Fix log files so that they log more data. 

[ ] - Run Glimpse; optimize database as necessary, add caching as needed.  

[ ] - Reseed Database. 



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

**Day Eight (March 15, 2018)**
+ Created entities to support a many-to-many relationship between videos and favorites. 
+ Used a migration to create the FavoriteVideos join table in the database.  
+ After very nearly breaking everything, I had to roll back to last commit, rebuild all User databases.
+ Add AspNetUsersId as foreign key to the FavoriteVideos Join Table.  Via SQL. 
+ Fixed the favorites action. Updated the favorites view.  Most everything is working.

**Day Nine (March 16, 2018)**
+ Added Ajax link to each video to save to user's list of favorites. Added error handling to link. 
+ Added alert that pops up when video is successfully added to favorites. 

**Day 10 (March 17, 2018)**
+ Added capability to remove videos from favorites.

**Day 11 (March 18, 2018)**
+ Added "About ASMR" section to front page.  
+ Created the table, controller, and form (in footer partial) to allow users to submit errors. 

**Day 12 (March 19, 2018)**
+ Removed jQuery script from partial view to eliminate an error. 
+ Added logging via NLog.  

**Day 13 (March 20, 2018)**
+ Added "Beta" to title in header. 

**Day 14 (March 21, 2018)**
+ Removed some unnecessary, now unused code. 
+ Made the "Register"/"Login" buttons on the front page conditional. 


## Credit

- **Steve Bogucki**

ISO full-time junior to mid dev position in the Los Angeles area. Would consider relocation, but only to Minneapolis (weird, I know, but I grew up in the area).  My strength is C# fundamentals, .NET MVC and Web API, including all related technology: Entity Framework, SQL Server, LINQ etc.  I've deployed apps to Azure, Heroku, and AWS with Angular and AngularJS front-ends, but I intend to relearn vanilla JavaScript from the ground-up, just as I have C#.  Please check out my LinkedIn: 

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


+ Day Eight (March 15, 2018):

*Created a many-to-many Join Table in SQL Server via Entity Framework:*

![Imgur](https://i.imgur.com/1dq96lh.jpg)


*Moments before this, there was almost disaster:*

![Imgur](https://i.imgur.com/0fHgxq0.jpg)


+ Day Nine (March 16, 2018):

*You can now save videoss to your list of Favorites:*

![Imgur](https://i.imgur.com/lkN6ytO.jpg)



+ Day Eleven (March 18, 2018):

*The front page currently with the "About ASMR" section exposed:*

![Imgur](https://i.imgur.com/Ygk3a26.jpg)


+ Day Twelve (March 19, 2018):

*Logging; it's a work in progress.  Lol:*

![Imgur](https://i.imgur.com/VC1afPu.jpg)


+ Day Fourterrn (March 21, 2018):

*Login and Register buttons on the front page are now conditional:*

![Imgur](https://i.imgur.com/zD8ZNfC.jpg)


**Go Birds**

![Imgur](https://i.imgur.com/O0Hxg8b.jpg)








