# 📊 Database Schema Documentation

## Entities Overview

### Users (Người dùng)
- Id (PK)
- Username (Unique)
- Email (Unique)
- PasswordHash
- Role (Customer, Admin, Promoter)
- IsActive
- RowVersion (Optimistic Locking)

### Events (Sự kiện)
- Id (PK)
- Title
- VenueId (FK)
- Performer
- EventDate
- Status (Upcoming, Ongoing, Completed, Cancelled)
- TotalTickets
- AvailableTickets
- Price
- RowVersion

### Seats (Ghế)
- Id (PK)
- EventId (FK)
- SeatNumber (A1, B2, etc.)
- Row, SeatColumn
- SeatType (Standard, VIP, Premium)
- Price
- Status (Available, OnHold, Sold, Blocked)
- RowVersion

### Orders (Đơn hàng)
- Id (PK)
- OrderNumber (Unique)
- UserId (FK)
- EventId (FK)
- Status (Pending, Confirmed, Failed, Cancelled)
- TotalAmount
- TotalTickets
- RowVersion

### Payments (Thanh toán)
- Id (PK)
- OrderId (FK)
- Amount
- PaymentMethod
- Status (Pending, Completed, Failed, Refunded)
- TransactionId (Unique)

## Key Features

✅ **Optimistic Locking** - RowVersion on critical entities
✅ **High Concurrency** - Designed for peak load
✅ **Audit Trail** - AuditLog table for compliance
✅ **Seat Holding** - SeatHold with TTL
