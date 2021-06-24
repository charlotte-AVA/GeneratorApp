# Generator App
Avanade Practical Project, developed by Charlotte Mythen

##### Product details
Predicted Release Date: 24/06/21

Rationale: For project purposes only. 

##### developer info 
Name: Charlotte Mythen

##### Product features
* English language only
* Service 1: Random generated song 
* Service 2: Random generated artist 
* Service 3: Merged song + artist
* Service 4: Front-end display

##### Product description
Intended for use as a game only. 
No user information is stored. 
No previous scores are logged.


##### Product planning

###### Technologies used: 
- Azure Boards - Project Management
- C# / ASP.NET - core web app MVC (1); core web API (3)
- SQL(Azure) - Database
- XUnit - testing
- Git - VCS
- Git Hub Actions (f. Azure Pipelines) - CI/CD Server
- Azure - Cloud Platform
- Ansible - Configuration Management
- Terraform - Infrastructure as Code

##### Product design

Examples of Musical impression generator games:

![Jimmy Fallon show: Wheel of Musical Impressions](https://s3.r29static.com/bin/public/369/0,0,600,315/x,80/1476953/image.jpg)


###### Service 1 - SONGS
A SONG generator with 2 different implementations available:

One that creates songs (strings) from the decade 00's.
One that creates songs (strings) from the decade 80's.

###### Service 2 - SINGERS
A SINGER generator with 2 different implementations available:

One that creates a SOLO artist (strings).
One that creates a GROUP/BAND (strings).

###### Service 3 - MERGE
A MUSICAL IMPRESSIONS generator with 2 different implementations available, in both cases the MUSICAL IMPRESSION is determined by the concatenated string generated above.

One for when there are no points. Friendly game.  
One for when the game is points-based. +1 point(s) for correct genre. +3 point(s) for matching artist-song. 

###### Service 4 - FRONTEND
Frontend. 

###### Example User Journey
A page is loaded and a MUSCIAL IMPRESSION is generated, it is "SONG X by ARTIST Y”.

If scoring with points:  
Because the SONG and SINGER match, the user gets an additional +3 point(s), this is described in the logic of service 4.
The Back-end completes the logic to decide the prize number, based upon the account number originally created, and displays this for the user.

**_To resrat the game press the refresh button!_**
