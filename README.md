![Collabco](https://www.collabco.co.uk/media/1082/logo-small.png)

# Full Stack Technical Assessment

Firstly, welcome and thank you for considering Collabco the next step in your career and taking the time to show us your dev skills.

The aim of the project is to help demostrate the existing skills you posses and illusate your strengths. If you find yourself struggling on any area, try to move on and focus on where you feel best demonstrates your abilities.

This project has the opportunity to demostrate your skills in the following areas:
1. C#
2. ASP.NET Core
3. Angular
4. Typescript / Javascript
5. CSS
6. Unit Testing
7. Error handling

This sample project uses libraries and frameworks we use here at Collabco, if you are familar with others and feel that would better demonstrate your skills, use that. Don't burn lots of time learning something brand new unless you want to and have the time.

We tend to focus our development efforts around user stories, and feel that rather than a list of prescribed tasks, giving you the freedom to demostrate how you would implement these is much more realistic. In here you will find a selection of user stories to documented with some additional details that may help.

Complete as many of the requirements as you can, and then we will review the code, giving you the opportunity to share your reasoning behind your implementation and for our team to share any feedback they have.

## Setup

1. [Visual Studio](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=15) or [Visual Code](https://code.visualstudio.com/docs?dv=win&wt.mc_id=DX_841432&sku=codewin)
2. [NodeJs](https://nodejs.org/en/)

## Requirements and User Stories
myday is a customisable Digital Campus that collects, 
displays and pushes information from disparate IT systems.  
The myday platform leverages all existing IT investments 
by bringing them together onto one customisable tiled 
interface. Using the adaptable features, 
the platform allows you to execute targeted communications empowering your institute to 
recruit, engage, connect and retain both students and staff.

Students want the ability to manage their 
lives by having access to all relevant information at 
any given time, from any location. For many, this focus on 
the student experience is a key consideration when choosing where to study. 
myday enables students to be better connected even when on the go, 
anytime, anywhere, making their academic experience better!

A huge part of campus life is the courses you chose to undertake as part of your studies. 
This project focuses on providing users with a list of courses they could potentially study.
Typically, myday will integrate with the institutes systems to provide course data. 

In this instance, course data is available over a web service - https://collabco-course-api.azurewebsites.net/api/v1/Course. 

As with all integrations, availability of third party services can have impacts on our applications so be cautious of errors....

With this project we would like to fulfill the following user stories:
1. As a user I must be able to view a list of all courses
2. As a user I must be able to view the course name, a short description, a start date and the duration in months
3. As a user I should be able to filter based on start date
4. As a user I should be able to filter based on name
5. As a user I could be able to view a more detailed description of the course

## Project
Within the existing project you will find the following:
1. **Myday.Course.App**
This is a dotnet core project hosting both a Angular SPA and WebApi endpoints.
To run the project, either click debug in Visual Studio or VS Code or run the following from the command line in the directory:     
    ``` 
     npm i
	dotnet restore
	dotnet run
	```

2. **Myday.Course.App.Tests**
This is a xUnit test project setup to run unit tests on the Myday.Course.App project.
To run the project, either use Visual Studio Test Explorer or run the following commands from the command line in the directory:
    ```
	dotnet restore
	dotnet test
	```

## Resources
We know there may be a few new bits of tech in here so here are a set of resources that should help you fulfill the users requirements.
1. [dotnet Core Web Api](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.1)
2. [xUnit](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-2.1)

## Complete
When your complete bundle up your project and send it to our team.
1. Commit all changes locally
2. Bundle up your repository using the following command:
    ```bash
    git bundle create collabco-full-stack-assessment.bundle --all
    ```
3. Upload the file you just created **"collabco-full-stack-assessment.bundle"** to a file sharing provider
4. Finally, email our team the download link: luke.miles@collabco.co.uk