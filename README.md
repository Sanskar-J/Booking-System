# Project Photography Booking System

This repository contains a Visual Studio .NET Windows Form project written in C# that implements a Photography Booking System. The system allows users to book photography sessions and manage the bookings efficiently. The project has two branches, `v1` and `v2`, each connected to a different database.

## Branches

### v1

The `v1` branch contains the application connected to a MySQL database. This version of the project utilizes MySQL as the underlying database management system. Users can interact with the application to book photography sessions, view existing bookings, and perform various management operations.

### v2

The `v2` branch contains the application connected to a MongoDB Atlas object-relational database. This version of the project utilizes MongoDB as the database technology. Users can utilize the application to book photography sessions, view existing bookings, and perform management tasks. The integration with MongoDB Atlas offers increased scalability and flexibility.

## Features

The Photography Booking System project offers the following features:

- User-friendly Windows Form interface for intuitive interaction.
- Booking functionality to allow users to schedule photography sessions.
- View and manage existing bookings.
- Integration with either MySQL or MongoDB Atlas databases, depending on the branch.
- Database connectivity for efficient storage and retrieval of data.
- Scalability and flexibility, particularly with MongoDB Atlas integration in `v2` branch.

## Installation and Setup

To set up the project on your local machine, follow these steps:

1. Clone the repository to your local machine using the following command:
   ```
   git clone https://github.com/your-username/repository-name.git
   ```

2. Open the project in Visual Studio .NET.

3. Select the desired branch (`v1` for MySQL or `v2` for MongoDB Atlas) using the following command:
   ```
   git checkout branch-name
   ```

4. Configure the database connection settings according to your setup. Refer to the appropriate branch's README for specific instructions.

5. Build the solution in Visual Studio to compile the project.

6. Run the application to start using the Photography Booking System.

## Database Configuration

### MySQL (v1 branch)

To connect the application to a MySQL database:

1. Install MySQL on your machine if you haven't already.
2. Create a new MySQL database.
3. Update the database connection string in the application's configuration files with your MySQL database details.

### MongoDB Atlas (v2 branch)

To connect the application to a MongoDB Atlas database:

1. Create a MongoDB Atlas account if you don't have one already.
2. Set up a new MongoDB Atlas cluster.
3. Obtain the connection string for your cluster.
4. Update the database connection string in the application's configuration files with your MongoDB Atlas connection string.

For detailed instructions, refer to the README file in the `v1` or `v2` branch, depending on your chosen database.

## Contribution

Contributions to the Photography Booking System project are welcome! If you encounter any issues or have suggestions for improvements, please open an issue or submit a pull request. Your contributions will help enhance the functionality and usability of the project.

## License

The Photography Booking System project is licensed under the [MIT License](https://opensource.org/licenses/MIT). See the [LICENSE](LICENSE) file for more details.

## Contact

If you have any questions or need further assistance, feel free to contact the project maintainer at [sanskar.moc.liamg@gmail.com](mailto:sanskar.moc.liamg@gmail.com).

Thank you for your interest in the Photography Booking System project! We hope it proves useful for your photography business or any similar application.

## Screenshots
![Screenshot 1](https://github.com/Sanskar-J/Booking-System/blob/v3/Booking%20System/Screenshots/Screenshot%20(36).png)
![Screenshot 2](https://github.com/Sanskar-J/Booking-System/blob/v3/Booking%20System/Screenshots/Screenshot%20(37).png)
![Screenshot 3](https://github.com/Sanskar-J/Booking-System/blob/v3/Booking%20System/Screenshots/Screenshot%20(38).png)
![Screenshot 4](https://github.com/Sanskar-J/Booking-System/blob/v3/Booking%20System/Screenshots/Screenshot%20(39).png)
![Screenshot 5](https://github.com/Sanskar-J/Booking-System/blob/v3/Booking%20System/Screenshots/Screenshot%20(40).png)
![Screenshot 6](https://github.com/Sanskar-J/Booking-System/blob/v3/Booking%20System/Screenshots/Screenshot%20(41).png)
![Screenshot 7](https://github.com/Sanskar-J/Booking-System/blob/v3/Booking%20System/Screenshots/Screenshot%20(42).png)
![Screenshot 2](data:image/jpeg;base64,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)
