Recreate the Login and registration assignment using models and model validations.

Registration
The user inputs his/her information, we verify that the information is correct, insert it into the database and return back with a success message. If the information is not valid, redirect to the registration page and show the following requirements:

Validations and Fields to Include

First Name - letters only, at least 2 characters and that it was submitted
Last Name - letters only, at least 2 characters and that it was submitted
Email - Valid Email format, and that it was submitted
 
Password - at least 8 characters, and that it was submitted
Password Confirmation - matches password
Login
When the user initially registers we would log them in automatically, but the process of "logging in" is simply just verifying that the email and password the user is providing matches up with one of the records that we have in our database table for users.