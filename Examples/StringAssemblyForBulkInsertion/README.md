## What is this example

It is a small / simple example, to demonstrate a simple and optimized logic for assembling an insertion string using the passing of an object.  

In this example, I divide the amount of elements inside the list, if the division is not exact, I round it up, use skip and take to cut the array.  

That way, I don't need to worry about index  

The result of this code is: 

`INSERT INTO [Book] (Name, Author, Isbn, ReleaseDate) VALUES ('Capitaes da areia', 'Jorge Amado', '8535914064', '18/07/2021 22:47:18'),('Dona flor e seus dois maridos', 'Jorge Amado', '8535911707', '18/07/2021 22:47:18')`  
`INSERT INTO [Book] (Name, Author, Isbn, ReleaseDate) VALUES ('Tieta do agreste', 'Jorge Amado', '8535914048', '18/07/2021 22:47:18'),('Gabriela, Cravo e Canela', 'Jorge Amado', '8535920986', '18/07/2021 22:47:18')`  
`INSERT INTO [Book] (Name, Author, Isbn, ReleaseDate) VALUES ('Mar morto', 'Jorge Amado', '8535911820', '18/07/2021 22:47:18')`  

## Project Type Console

.NET 5.0
