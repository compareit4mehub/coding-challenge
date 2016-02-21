### Challenge 1
Create an application that allows the uploading of a file. Once the file is loaded, the application must validate and parse each line of file information (plaintext) and then upload the information to the database.
The file structure is as follows:

`x, y, z`

- x is the username id of a user. Its length is 10 characters. They are just numbers, and can have zeros on the left. 
- y the amount of coins associated with the user x. must accept only natural numbers.
- z is the user name x.


The three fields are mandatory and can not be blank.
If you find a wrong value when making the validation of each line, stop the process and if the database is modified, returning it to its initial state. Warn the user which line had an error.

--

### Challenge 2
Using this webservice (http://www.webservicex.net/ConvertTemperature.asmx?WSDL), make a web calculator to do conversions of temperature. Preferably the results should be displayed asynchronously.

--

### Challenge 3
Lets assume we are an online marketing company. We got some new requirment to capture phone numbers of our customers every customer can have many phone numbers (1 customer : N phone numbers) and we need following 3 REST APIs from backend team:

1. Get all phone numbers
2. Get all phone numbers of a single customer
3. Activate a phone number

---

###### Notes:
1. Push code to github
2. Use 1 pull request per coding challenge for code merging.
3. Try to deploy your solution on free hosting provider.
