#Marvel Test

What I used and why...
-------------

I chose to create this solution using .NET (Xamarin Studio, because I'm on a Mac), basicaly because it is where I feel more confortable when it's not a mobile solution. Though I've considered to use Ruby or plain HTML using some JS framework.

How to run it...
-----------

I've developed it with Xamarin Studio, it should build in a Windows environment as well.

- Clone this repository
- Open Avidity.MarvelTest.sln (Xamarin Studio or Visual Studio)
- Restore Packages of the solution, do not Update, just restore them.
- Run it

About the architecture...
--------

-	Domain Driven Design (DDD) - Even not having a big deal in terms of domain rules, I used it because it makes easier to maintain the solution.
-	Inversion of control (IoC) - To keep it clean, and not to mess with domain objects.
-	Model View Controller (MVC) - It is a good pattern using .NET and I like it.
-	System Pattern - I could've used a Repository Pattern, but I wouldn't implement a bunch of methods I found it simpler to create as Systems, also I could keep the Marvel's access complexity in an isolated point.


Considerations...
--------

- I really enjoyed myself doing this test, and I'm sorry about the delay and reschedules, but it is not something that you have to worry about, I am really commited to work.
- There are some things that I would like to think a little bit more and maybe I could come with a better solution with its architecture.
- I took liberty to use partially the CSS of Avidity's website, basically Fonts and also I wanted to keep it simple. Although, for something involving Marvel universe I would love to create something "shiny"
- I tryed to publish it with AppHarbor in case you wanted to see it live, but for some reason it builded the solution but no page was published, and I had no time to figure out what happened :(
