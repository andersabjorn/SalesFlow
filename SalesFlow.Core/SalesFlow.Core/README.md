# SalesFlow.Core

Business logic and domain models.

## Structure

- **Entities/**: Domain entities (Lead, Offer, Order, Invoice, Payment)
- **Enums/**: Domain enums (LeadStatus, OfferStatus, etc.)
- **Interfaces/**: Abstractions for repositories and services

## Rules

- No dependencies on other projects
- No external library dependencies (except .NET base)
- Pure business logic only