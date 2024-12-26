# Library Management System

## Overview
The Library Management System is a console-based application designed to manage books, members, and borrowing activities. The system demonstrates Object-Oriented Programming (OOP) principles, including encapsulation, inheritance, polymorphism, and abstraction.

---

## Features
- **Add Books**: Add new books to the library’s collection.
- **View Available Books**: Display all available books in the library.
- **Borrow Books**: Members can borrow books, and the system marks them as unavailable.
- **Return Books**: Members can return borrowed books, making them available again.
- **Add Members**: Register new members to the library.
- **View Members**: Display member details and their borrowed books.

---

## OOP Concepts Used
### 1. Encapsulation
- Classes like `Book`, `Member`, and `Library` encapsulate related properties and methods.

### 2. Inheritance
- `Member` inherits from an abstract class `User`.

### 3. Polymorphism
- `DisplayDetails` method is overridden in `Member` to provide specific behavior.

### 4. Abstraction
- An abstract class `User` defines general behaviors for all types of users.

---

## Classes
### 1. `Book`
Represents a book in the library.
- Properties: `Title`, `Author`, `IsBorrowed`
- Methods: `DisplayDetails()`

### 2. `User` (Abstract Class)
Base class for all users.
- Properties: `Name`, `UserID`
- Methods: `DisplayDetails()` (abstract)

### 3. `Member` (Derived Class)
Represents a library member.
- Properties: `BorrowedBooks`
- Methods: Overrides `DisplayDetails()`

### 4. `Library`
Manages the collection of books and members.
- Methods: `AddBook()`, `AddMember()`, `BorrowBook()`, `ReturnBook()`, `DisplayAvailableBooks()`, `DisplayMembers()`
