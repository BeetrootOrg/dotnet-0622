#Password Manager

This repository describes Password Manager API

##User stories

1.As a user, I want to create/delete account, so that I can use this application.
2.As a user, I want to add/remove password, so that it is saved(in encrypted form) /deleted in a database.
3.As a user, I want to update the password, so that it updates in the database.
4.As a user, I want to get my password, so that application decrypt it with my key and provides me with it.

##Terms

-users - collection of users
-password - item inside user passwords

##HTTP API

###user

-PUT /api/users/ BODY - user details -> Reterns 204 No content
-GET /api/users/(master password) ->Reterns 200 OK / 400 Not Found if no such user
-POST /api/users/(master password) ->Reterns 200 OK / 400 Not Found if no such user

###password

-PUT /api/password/ BODY - password details -> Reterns 204 No content
-DELETE /api/password/(passwordId) - Reterns 204 No content
-GET /api/password/(passwordId) -> Reterns 200 OK / 400 Not Found if no such password 
-POST /api/password/(passwordId) BODY - password details -> Reterns 200 OK / 400 Not Found if no such password

##Models

###class User

-id
-username
-email
-password(encrypted, to compare while authorizing with a server)
-passwords(collection of encrypted passwords)

###class Password

-id
-website name
-encrypted password
