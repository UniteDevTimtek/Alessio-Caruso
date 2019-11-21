# Country Data Viewer 
 

## Purpose of the test

The test is designed to be a chance for us to see how you shape your code across the stack.  

It is not essential that you finish the test, more that you structure your code and develop as you would day to day. The test should take between 2-3 hours, and you are free to use any resource at your disposal.  

## Submission of your test

Please commit the full source code as you go, your final commit should leave the code base able to be run & debugged in visual studio. 

## Brief 

A member of the International Team has been given a list of ISO codes and asked to get the relevant Country information for each one. They have discovered an API which provides all the information they need and have asked the digital team to build a small application to facilitate the task in future. 

Using modern __c#__ (.Net framework or core) and __ES6__, build a simple web application to display country information. 

The API you have been asked to use is: https://restcountries.eu/#api-endpoints-code 

## User Story

*As a Research User*

*I wish to enter an ISO code (2 letters)*

*So that I may see the countries information in a human readable format*


## Acceptance Criteria: 

#### The Application Must: 

* Use a modern js framework (react, vue, angular) to display the data
* Cache responses from the API for 5 minutes
* Update the DOM without reloading the entire page 

#### The Application Should: 

* Present feed back to the user if the ISO code entered is invalid 
* Sanitise user input 


## Notes from Tom Hockings:

* 'npm install' should be run before building as I haven't included the node_nodules fodler in version control (ignore that obviously, I've remembered that it restores npm packages on build)

* I lost a lot of time at the start trying to get the hot moddule reloader working but I ultimately failed so had to press on without it. It was an error I had last time I set it up that I just can't remember what the fix for it was!

* I'd like to refactor how the data is displayed internally. I think I should have done a bit of data shaping in the back end to simplify the front end a lot but after I noticed how much time I lost with the hot module reloader I panicked a bit and forged ahead with the front end, which I now regret. The nesting of array data is a bit awkward but it works.

* I would also like to make better use of space of the front end but the acceptance criteria didn't mention anything about columns

* I originally intended to make the front end much more dynamic and data driven but the aforementioned panic made me forget about that intent.

* I'd have liked to have written some unit tests and tightened up error handling when fetching data from the api but I didn't have time. A few country codes failed when I tested a random selection due to not using nullable types. I made everything that might be null nullable but it would have been nice to assert that somewhere.
 

 