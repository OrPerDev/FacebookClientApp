# Facebook Client app

C# Facebook client app, created for a CS course assignment in design patterns.

This project's main target is to present the implementations of the following design patterns as part of the patterns learned in the course -

- Singleton
- Builder
- Proxy
- Iterator
- Template Method
- Strategy

Main View -

![MainClient](https://github.com/OrPerDev/FacebookClientApp/assets/91319947/81db3de8-0f00-471d-ad5e-595bb70f4d03)


## About The App

The app is a Facebook-like client written in C#, .Net Core 3, and Winforms.
The app displays some of Facebook's user data and also contains two new features!
- Facebook Best Friend
- Facebook Resume Builder

## Facebook Best Friend Feature

This Feature determines who is the user's best friend while iterating over the User's friends and calculating their friend score based on the following:

- Interactions did between the users:
  -  Number of tags the friend tagged the user.
  -  Number of likes between the friend and the user.
  -  Number of comments the friend commented on the user's content.
-  Number of mutual friends.
-  Number of mutual groups.

In this feature the following patterns were implemented:
- Builder
  - In order to build the complex object which helps to represent the best friend and his/hers score.
- Iterator
  - Used as filter-iterator as a sub-feature to allow the user to add names to filter out from the iteration.
- Strategy
  - Used in order to let better extensibility to create scores scoring strategies.

View - 

![BestFriend](https://github.com/OrPerDev/FacebookClientApp/assets/91319947/e5d6278e-ce5e-470e-a7f3-c9c323bd9b21)

## Facebook Resume Builder Feature

This Feature collects the user's data from facebook and creates a resume-like document, moreover the feature let the user add additional content which cannot be found in the user's data collected.

In this feature the following patterns were implemented:
- Template Method
  - In order to allow flexability in future text creation of the resume.
- Proxy
  - To wrap the user's data is with other additional data which will be presented in the resume.

View -

![ResumeBuilder](https://github.com/OrPerDev/FacebookClientApp/assets/91319947/ba0556bd-5413-47fd-8ff8-43044f62e4fc)

## Note

The Singleton design pattern was implemented in a generic way - with thread lock double safety.

The singleton design pattern is used both in the App Serialization and The App Manager.

### Special Thanks
To my lecturer in the course - Guy Ronen for providing the Facebook API dll.
