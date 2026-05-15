# Outputs.Documents.Domain

Stable shared domain concepts for document contracts.

This project contains reusable insurance/document concepts that are independent from any one origin system. Origin-specific copybook contracts live under `origins/`, not here.

## What Lives Here

- Semantic annotation:
  - `DomainSearchAttribute`
- Document-level concepts:
  - `DocumentInformation`
  - `DocumentTraceId`
  - `Header`
  - `Footer`
  - generic text/table primitives
- Parties and people:
  - `Entity`
  - `ContactDetails`
  - `InsuredPerson`
- Locations:
  - `PostalAddress`
- Expedition:
  - `SingleRegisterTicket`
- Payments:
  - `BankAccount`
  - `AtmPaymentReference`
- Policies:
  - `Policy`
  - `PolicyReference`
  - `ProductReference`
  - `Premium`
  - `Coverage`
  - risk detail types

## Rules

- Keep this project stable and origin-neutral.
- Do not add Razor, rendering, PDF, dashboard, storage, or DI code.
- Do not put DOCE/FSCD copybook contract classes here.
- Do not put sample data here.
- Add `DomainSearchAttribute` to searchable domain classes and properties.
- Prefer reusable business concepts over raw copybook field dumps.

## When To Add Something Here

Add a type here when it is likely to be reused by multiple origin systems or multiple contracts, for example:

- postal address
- entity/person
- policy reference
- premium
- coverage
- risk detail
- bank account

Keep a type in an origin contract project when it is specific to one copybook or one source-system layout.
