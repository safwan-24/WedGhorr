# Wedding Planner Management System

## Project Overview

This project is a **Wedding Planner Management System** designed to streamline wedding planning operations with three distinct roles: **Customer**, **Admin**, and **Staff**. Each user type has separate login credentials, granting them access to different functionalities based on their role. The system enhances the efficiency of event planning by providing a user-friendly interface for managing bookings, payments, and staff schedules.

## Features

### Customer Panel
Once logged in, customers have access to a panel that includes the following options:

1. **Booking**: 
   - Allows customers to select the number of guests, beverages, meals, and other services.
   - The system automatically calculates the **grand total** based on the selected services.
   - Customers can confirm the booking, which then returns them to the main panel.
   
2. **Track Booking**:
   - Customers can track the status of their booking.
   
3. **Payment**:
   - After confirming a booking, customers can proceed to the **Payment** section, where they can choose their preferred payment method to complete the transaction.

### Admin Panel
When an admin logs in, they can manage the system by performing the following tasks:

1. **Modify Bookings**:
   - Admins can modify customer bookings based on requests or update details depending on inventory and availability.
   
2. **Staff Management**:
   - Admins have control over adding or removing staff members based on the operational needs of the business.

### Staff Panel
Staff members, after logging in, can perform the following operations:

1. **View Bookings**:
   - Staff can view and confirm the details of customer bookings.
   
2. **Confirm Payment**:
   - Staff members can review and confirm customer payments.
   
3. **View Schedule**:
   - Staff can check their assigned shifts and upcoming schedule to ensure proper event coverage.

## Technologies Used

- **C#** for application development
- **SQL Server** for database management
- **Windows Forms** for the user interface

## How to Use

1. **Clone the repository**: 
   ```bash
   git clone https://github.com/yourusername/wedding-planner-management-system.git
