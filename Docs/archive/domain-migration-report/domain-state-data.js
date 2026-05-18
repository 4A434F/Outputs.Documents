window.DOMAIN_STATE = [
  {
    "domain": "Documents",
    "name": "DocumentInformation",
    "displayName": "Document information",
    "namespace": "Outputs.Documents.Domain.Common.Documents",
    "file": "Core/src/Outputs.Documents.Domain/Common/Documents/DocumentInformation.cs",
    "description": "Reusable document information with document, print, company, brand, client, policy, and origin identifiers.",
    "aliases": [
      "document information",
      "registration header",
      "document envelope",
      "DADOS-REGISTO",
      "COD-DOCUMENTO",
      "TIPO-IMPRESSAO",
      "TIPO-DOC"
    ],
    "tags": [
      "common",
      "document",
      "information"
    ],
    "properties": [
      {
        "name": "DocumentCode",
        "displayName": "Document code",
        "type": "string?",
        "description": "Document code sent by the origin system.",
        "aliases": [
          "COD-DOCUMENTO",
          "BGOW9064-COD-DOCUMENTO"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "PrintType",
        "displayName": "Print type",
        "type": "string?",
        "description": "Print channel or print mode identifier.",
        "aliases": [
          "TIPO-IMPRESSAO",
          "BGOW9064-TIPO-IMPRESSAO",
          "BGOW9068-TIPO-IMPRESSAO"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "DocumentTypeCode",
        "displayName": "Document type code",
        "type": "string?",
        "description": "Document type code used by origin systems that expose a document category separately from the template/document identifier.",
        "aliases": [
          "TIPO-DOC",
          "BGOW9068-TIPO-DOC"
        ],
        "tags": [
          "field",
          "document",
          "header",
          "copybook:BGOW9068"
        ]
      },
      {
        "name": "UserId",
        "displayName": "Online user id",
        "type": "string?",
        "description": "User identifier for online or immediate printing.",
        "aliases": [
          "USERID",
          "BGOW9064-USERID"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "CompanyCode",
        "displayName": "Company code",
        "type": "string?",
        "description": "Company identifier.",
        "aliases": [
          "COD-COMPANHIA",
          "BGOW9064-COD-COMPANHIA",
          "COMPANY",
          "BGOW9068-COMPANY"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "BrandCode",
        "displayName": "Brand code",
        "type": "string?",
        "description": "Brand identifier.",
        "aliases": [
          "COD-MARCA",
          "BGOW9064-COD-MARCA",
          "MARCA",
          "BGOW9068-MARCA"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "AgentNumber",
        "displayName": "Agent number",
        "type": "string?",
        "description": "Agent or mediator number.",
        "aliases": [
          "NR-AGENTE",
          "BGOW9064-NR-AGENTE",
          "AGENTE-COBRADOR",
          "BGOW9068-AGENTE-COBRADOR"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "ClientNumber",
        "displayName": "Client number",
        "type": "string?",
        "description": "Client identifier.",
        "aliases": [
          "NR-CLIENTE",
          "BGOW9064-NR-CLIENTE",
          "CLIENT-REFERENCE",
          "BGOW9068-CLIENT-REFERENCE"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "PolicyNumber",
        "displayName": "Policy number",
        "type": "string?",
        "description": "Policy identifier.",
        "aliases": [
          "NR-APOLICE",
          "BGOW9064-NR-APOLICE",
          "POLICY-NUMBER",
          "BGOW9068-POLICY-NUMBER"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "PolicyTransactionCode",
        "displayName": "Policy transaction code",
        "type": "string?",
        "description": "Policy transaction identifier used by origin systems to identify the policy operation represented by the document.",
        "aliases": [
          "POLICY-TRANSACTION",
          "BGOW9068-POLICY-TRANSACTION"
        ],
        "tags": [
          "field",
          "document",
          "header",
          "policy",
          "copybook:BGOW9068"
        ]
      },
      {
        "name": "ProductCode",
        "displayName": "Product code",
        "type": "string?",
        "description": "Insurance product code carried in the document information envelope.",
        "aliases": [
          "PRODUTO",
          "BGOW9068-PRODUTO",
          "COD-PRODUTO",
          "BGOW0044-COD-PRODUTO"
        ],
        "tags": [
          "field",
          "document",
          "header",
          "product"
        ]
      },
      {
        "name": "OriginDocumentNumber",
        "displayName": "Origin document number",
        "type": "string?",
        "description": "Origin-system document number used for ordering or correlation.",
        "aliases": [
          "DOC-NR",
          "BGOW9064-DOC-NR"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "OriginSequenceNumber",
        "displayName": "Origin sequence number",
        "type": "string?",
        "description": "Origin-system record sequence number.",
        "aliases": [
          "DOC-SEQREG-NR",
          "BGOW9064-DOC-SEQREG-NR",
          "NUM-SEQ-1",
          "BGOW9068-NUM-SEQ-1"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "ProcessingDate",
        "displayName": "Processing date",
        "type": "string?",
        "description": "Origin-system processing date for the generated document.",
        "aliases": [
          "DATA-PROCESSAMENTO",
          "BGOW9068-DATA-PROCESSAMENTO"
        ],
        "tags": [
          "field",
          "document",
          "header",
          "copybook:BGOW9068"
        ]
      },
      {
        "name": "OriginSystemCode",
        "displayName": "Origin system code",
        "type": "string?",
        "description": "Origin-system identifier.",
        "aliases": [
          "COD-ORIGEM",
          "BGOW9064-COD-ORIGEM"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      },
      {
        "name": "FlyerIndicator",
        "displayName": "Flyer indicator",
        "type": "string?",
        "description": "Flyer inclusion indicator.",
        "aliases": [
          "IND-FLYER",
          "BGOW9064-IND-FLYER"
        ],
        "tags": [
          "field",
          "document",
          "header"
        ]
      }
    ]
  },
  {
    "domain": "Documents",
    "name": "DocumentTraceId",
    "displayName": "Document trace identifier",
    "namespace": "Outputs.Documents.Domain.Common.Documents",
    "file": "Core/src/Outputs.Documents.Domain/Common/Documents/DocumentTraceId.cs",
    "description": "Reusable document trace text printed on DOCE documents for operational identification.",
    "aliases": [
      "trace id",
      "trace text",
      "document trace"
    ],
    "tags": [
      "common",
      "doce",
      "trace",
      "identifier"
    ],
    "properties": []
  },
  {
    "domain": "Documents",
    "name": "Footer",
    "displayName": "DOCE footer",
    "namespace": "Outputs.Documents.Domain.Common.Documents",
    "file": "Core/src/Outputs.Documents.Domain/Common/Documents/Footer.cs",
    "description": "Reusable footer model for DOCE document templates.",
    "aliases": [
      "footer",
      "document footer"
    ],
    "tags": [
      "common",
      "doce",
      "footer"
    ],
    "properties": []
  },
  {
    "domain": "Documents",
    "name": "Header",
    "displayName": "DOCE header",
    "namespace": "Outputs.Documents.Domain.Common.Documents",
    "file": "Core/src/Outputs.Documents.Domain/Common/Documents/Header.cs",
    "description": "Reusable header model with logo path, title, and subtitle for DOCE document templates.",
    "aliases": [
      "header",
      "document header",
      "logo header"
    ],
    "tags": [
      "common",
      "doce",
      "header",
      "branding"
    ],
    "properties": []
  },
  {
    "domain": "Documents",
    "name": "GenericTable",
    "displayName": "Generic table",
    "namespace": "Outputs.Documents.Domain.Common.Documents.Primitives",
    "file": "Core/src/Outputs.Documents.Domain/Common/Documents/Primitives/GenericTable.cs",
    "description": "Reusable document table primitive with column definitions, row data, totals, and formatting.",
    "aliases": [
      "table",
      "custom table",
      "document table"
    ],
    "tags": [
      "common",
      "primitive",
      "table"
    ],
    "properties": []
  },
  {
    "domain": "Documents",
    "name": "TextBlock",
    "displayName": "Text block",
    "namespace": "Outputs.Documents.Domain.Common.Documents.Primitives",
    "file": "Core/src/Outputs.Documents.Domain/Common/Documents/Primitives/TextBlock.cs",
    "description": "Reusable text-only block for notes, clauses, descriptions, and document free text.",
    "aliases": [
      "text block",
      "notas",
      "descricao",
      "NC-NOTAS-COB"
    ],
    "tags": [
      "common",
      "text"
    ],
    "properties": [
      {
        "name": "Text",
        "displayName": "Text",
        "type": "string?",
        "description": "Free text content.",
        "aliases": [
          "NC-NOTAS-COB",
          "BGOW9064-NC-NOTAS-COB"
        ],
        "tags": [
          "field",
          "text"
        ]
      }
    ]
  },
  {
    "domain": "Documents",
    "name": "TitledSubtitleTextBlock",
    "displayName": "Titled subtitle text block",
    "namespace": "Outputs.Documents.Domain.Common.Documents.Primitives",
    "file": "Core/src/Outputs.Documents.Domain/Common/Documents/Primitives/TitledSubtitleTextBlock.cs",
    "description": "Reusable title, subtitle, and text block for richer clauses, notes, and document free text.",
    "aliases": [
      "titled subtitle text block",
      "title subtitle text",
      "clause text"
    ],
    "tags": [
      "common",
      "text"
    ],
    "properties": [
      {
        "name": "Title",
        "displayName": "Title",
        "type": "string?",
        "description": "Text block title.",
        "aliases": [
          "title",
          "titulo"
        ],
        "tags": [
          "field",
          "text"
        ]
      },
      {
        "name": "Subtitle",
        "displayName": "Subtitle",
        "type": "string?",
        "description": "Text block subtitle.",
        "aliases": [
          "subtitle",
          "subtitulo"
        ],
        "tags": [
          "field",
          "text"
        ]
      },
      {
        "name": "Text",
        "displayName": "Text",
        "type": "string?",
        "description": "Text block content.",
        "aliases": [
          "text",
          "descricao",
          "descritivo"
        ],
        "tags": [
          "field",
          "text"
        ]
      }
    ]
  },
  {
    "domain": "Documents",
    "name": "TitledTextBlock",
    "displayName": "Titled text block",
    "namespace": "Outputs.Documents.Domain.Common.Documents.Primitives",
    "file": "Core/src/Outputs.Documents.Domain/Common/Documents/Primitives/TitledTextBlock.cs",
    "description": "Reusable title and text block for conditions, clauses, notes, and document free text.",
    "aliases": [
      "titled text block",
      "condicoes gerais",
      "clausulas",
      "CG-CODIGO",
      "CG-DESCRITIVO"
    ],
    "tags": [
      "common",
      "text"
    ],
    "properties": [
      {
        "name": "Title",
        "displayName": "Title",
        "type": "string?",
        "description": "Text block title or code.",
        "aliases": [
          "CG-CODIGO",
          "DC-TIPO-DEC-CLAUS",
          "BGOW9064-CG-CODIGO",
          "BGOW9064-DC-TIPO-DEC-CLAUS"
        ],
        "tags": [
          "field",
          "text"
        ]
      },
      {
        "name": "Text",
        "displayName": "Text",
        "type": "string?",
        "description": "Text block content.",
        "aliases": [
          "CG-DESCRITIVO",
          "DC-DESCRITIVO",
          "BGOW9064-CG-DESCRITIVO",
          "BGOW9064-DC-DESCRITIVO"
        ],
        "tags": [
          "field",
          "text"
        ]
      }
    ]
  },
  {
    "domain": "Documents",
    "name": "PrintPayloadRecordControl",
    "displayName": "Print payload record control",
    "namespace": "Outputs.Documents.Domain.Common.Documents",
    "file": "Core/src/Outputs.Documents.Domain/Common/Documents/PrintPayloadRecordControl.cs",
    "description": "Record-control and raw print payload markers for fixed-width document copybooks that split printable content into typed lines.",
    "aliases": [
      "RECORD-TYPE-1",
      "RECORD-TYPE-2",
      "TYPE-1-2",
      "PRINT-DATA",
      "NUM-SEQ-1"
    ],
    "tags": [
      "common",
      "document",
      "print-payload",
      "record-control"
    ],
    "properties": [
      {
        "name": "SequenceNumber",
        "displayName": "Sequence number",
        "type": "string?",
        "description": "Sequence number of the print payload record.",
        "aliases": [
          "NUM-SEQ-1",
          "BGOW9068-NUM-SEQ-1"
        ],
        "tags": [
          "field",
          "document",
          "print-payload",
          "copybook:BGOW9068"
        ]
      },
      {
        "name": "PrimaryRecordType",
        "displayName": "Primary record type",
        "type": "string?",
        "description": "Primary record type marker for a fixed-width document print payload record.",
        "aliases": [
          "RECORD-TYPE-1",
          "BGOW9068-RECORD-TYPE-1"
        ],
        "tags": [
          "field",
          "document",
          "print-payload",
          "copybook:BGOW9068"
        ]
      },
      {
        "name": "SecondaryRecordType",
        "displayName": "Secondary record type",
        "type": "string?",
        "description": "Secondary record type marker for a fixed-width document print payload record.",
        "aliases": [
          "RECORD-TYPE-2",
          "BGOW9068-RECORD-TYPE-2"
        ],
        "tags": [
          "field",
          "document",
          "print-payload",
          "copybook:BGOW9068"
        ]
      },
      {
        "name": "CompositeRecordType",
        "displayName": "Composite record type",
        "type": "string?",
        "description": "Composite record type formed from the print payload record type fragments.",
        "aliases": [
          "TYPE-1-2",
          "BGOW9068-TYPE-1-2"
        ],
        "tags": [
          "field",
          "document",
          "print-payload",
          "copybook:BGOW9068"
        ]
      },
      {
        "name": "RawPrintData",
        "displayName": "Raw print data",
        "type": "string?",
        "description": "Raw printable data area carried by the fixed-width document payload record.",
        "aliases": [
          "PRINT-DATA",
          "BGOW9068-PRINT-DATA"
        ],
        "tags": [
          "field",
          "document",
          "print-payload",
          "copybook:BGOW9068"
        ]
      }
    ]
  },
  {
    "domain": "Entities",
    "name": "ContactDetails",
    "displayName": "Contact details",
    "namespace": "Outputs.Documents.Domain.Common.Entities",
    "file": "Core/src/Outputs.Documents.Domain/Common/Entities/ContactDetails.cs",
    "description": "Reusable contact block for phone, mobile phone, and e-mail values.",
    "aliases": [
      "contactos",
      "telefone",
      "telemovel",
      "email"
    ],
    "tags": [
      "common",
      "entity",
      "contact"
    ],
    "properties": []
  },
  {
    "domain": "Entities",
    "name": "Entity",
    "displayName": "Entity",
    "namespace": "Outputs.Documents.Domain.Common.Entities",
    "file": "Core/src/Outputs.Documents.Domain/Common/Entities/Entity.cs",
    "description": "Reusable person or organization entity block used for clients, mediators, creditors, and other document parties.",
    "aliases": [
      "entity",
      "client",
      "cliente",
      "entidade",
      "DADOS-CLIENTE",
      "CLIENT-REFERENCE",
      "TM-ADDRESSEE"
    ],
    "tags": [
      "common",
      "entity",
      "party"
    ],
    "properties": [
      {
        "name": "Reference",
        "displayName": "Entity reference",
        "type": "string?",
        "description": "Source-system reference or number that identifies the entity within the document context.",
        "aliases": [
          "CLIENT-REFERENCE",
          "BGOW9068-CLIENT-REFERENCE",
          "NR-CLIENTE",
          "BGOW9064-NR-CLIENTE"
        ],
        "tags": [
          "field",
          "entity"
        ]
      },
      {
        "name": "Number",
        "displayName": "Entity number",
        "type": "string?",
        "description": "Source-system number that identifies the entity in contexts that use number terminology.",
        "aliases": [
          "Number",
          "CLIENT-REFERENCE",
          "BGOW9068-CLIENT-REFERENCE",
          "NR-CLIENTE",
          "BGOW9064-NR-CLIENTE"
        ],
        "tags": [
          "field",
          "entity"
        ]
      },
      {
        "name": "Name",
        "displayName": "Name",
        "type": "string?",
        "description": "Entity display name.",
        "aliases": [
          "CL-NOME",
          "BGOW9064-CL-NOME",
          "TM-ADDRESSEE",
          "BGOW9068-TM-ADDRESSEE"
        ],
        "tags": [
          "field",
          "entity"
        ]
      },
      {
        "name": "TaxIdentificationNumber",
        "displayName": "Tax identification number",
        "type": "string?",
        "description": "Entity fiscal or tax identification number.",
        "aliases": [
          "CL-NIF",
          "BGOW9064-CL-NIF",
          "NIF"
        ],
        "tags": [
          "field",
          "entity"
        ]
      },
      {
        "name": "TypeCode",
        "displayName": "Entity type",
        "type": "string?",
        "description": "Entity type code, such as individual or collective.",
        "aliases": [
          "CL-TIPO-ENTIDADE",
          "BGOW9064-CL-TIPO-ENTIDADE"
        ],
        "tags": [
          "field",
          "entity"
        ]
      },
      {
        "name": "Type",
        "displayName": "Entity type",
        "type": "EntityType",
        "description": "Normalized entity type when the source value is known as person, organization, or unknown.",
        "aliases": [
          "tipo entidade",
          "party type",
          "entity type"
        ],
        "tags": [
          "field",
          "entity"
        ]
      },
      {
        "name": "Address",
        "displayName": "Entity address",
        "type": "PostalAddress?",
        "description": "Postal address associated with the entity when the source copybook sends the party and address together.",
        "aliases": [
          "DADOS-MORADA",
          "TM-ADDRESS1",
          "BGOW9068-TM-ADDRESS1",
          "MR-MORADA1",
          "BGOW9064-MR-MORADA1"
        ],
        "tags": [
          "field",
          "entity",
          "address"
        ]
      },
      {
        "name": "Contact",
        "displayName": "Entity contact details",
        "type": "ContactDetails?",
        "description": "Phone, mobile phone, and email contacts associated with the entity.",
        "aliases": [
          "contactos",
          "telefone",
          "telemovel",
          "email",
          "AG-TELEFONE",
          "AG-TELEMOVEL",
          "AG-EMAIL"
        ],
        "tags": [
          "field",
          "entity",
          "contact"
        ]
      }
    ]
  },
  {
    "domain": "Entities",
    "name": "InsuredPerson",
    "displayName": "Insured person",
    "namespace": "Outputs.Documents.Domain.Common.Entities",
    "file": "Core/src/Outputs.Documents.Domain/Common/Entities/InsuredPerson.cs",
    "description": "Reusable insured person block used in life, health, and risk-unit details.",
    "aliases": [
      "pessoa segura",
      "insured person"
    ],
    "tags": [
      "common",
      "entity",
      "insured"
    ],
    "properties": []
  },
  {
    "domain": "Expedition",
    "name": "SingleRegisterTicket",
    "displayName": "Single register ticket",
    "namespace": "Outputs.Documents.Domain.Common.Expedition",
    "file": "Core/src/Outputs.Documents.Domain/Common/Expedition/SingleRegisterTicket.cs",
    "description": "Reusable expedition registered-mail ticket block with client, address, barcode, and registration code fields.",
    "aliases": [
      "register ticket",
      "registered ticket",
      "postal ticket",
      "barcode ticket"
    ],
    "tags": [
      "common",
      "expedition",
      "registered-mail",
      "ticket"
    ],
    "properties": []
  },
  {
    "domain": "Locations",
    "name": "PostalAddress",
    "displayName": "Postal address",
    "namespace": "Outputs.Documents.Domain.Common.Locations",
    "file": "Core/src/Outputs.Documents.Domain/Common/Locations/PostalAddress.cs",
    "description": "Reusable postal address block with recipient name, address lines, locality, postal code, country, and door information.",
    "aliases": [
      "morada",
      "address",
      "postal address",
      "localidade",
      "codigo postal",
      "DADOS-MORADA",
      "MR-NOME",
      "MR-MORADA1",
      "TM-ADDRESSEE",
      "TM-ADDRESS1"
    ],
    "tags": [
      "common",
      "location",
      "address"
    ],
    "properties": [
      {
        "name": "Name",
        "displayName": "Recipient name",
        "type": "string?",
        "description": "Recipient or address name.",
        "aliases": [
          "MR-NOME",
          "BGOW9064-MR-NOME",
          "TM-ADDRESSEE",
          "BGOW9068-TM-ADDRESSEE"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "Reference",
        "displayName": "Address reference",
        "type": "string?",
        "description": "Address location reference from the source system.",
        "aliases": [
          "MR-LOCATION-REF",
          "BGOW9064-MR-LOCATION-REF",
          "LOCATION-REF"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "Line1",
        "displayName": "Address line 1",
        "type": "string?",
        "description": "First address line.",
        "aliases": [
          "MR-MORADA1",
          "BGOW9064-MR-MORADA1",
          "TM-ADDRESS1",
          "BGOW9068-TM-ADDRESS1"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "Line2",
        "displayName": "Address line 2",
        "type": "string?",
        "description": "Second address line.",
        "aliases": [
          "MR-MORADA2",
          "BGOW9064-MR-MORADA2",
          "TM-ADDRESS2",
          "BGOW9068-TM-ADDRESS2"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "Line3",
        "displayName": "Address line 3",
        "type": "string?",
        "description": "Third display address line used by template-facing address blocks.",
        "aliases": [
          "AddressLine3",
          "TM-ADDRESS3",
          "BGOW9068-TM-ADDRESS3"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "Line4",
        "displayName": "Address line 4",
        "type": "string?",
        "description": "Fourth display address line used by template-facing address blocks.",
        "aliases": [
          "AddressLine4",
          "TM-ADDRESS4",
          "BGOW9068-TM-ADDRESS4"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "Locality",
        "displayName": "Locality",
        "type": "string?",
        "description": "Address locality.",
        "aliases": [
          "MR-LOCALIDADE",
          "BGOW9064-MR-LOCALIDADE",
          "TM-ADDRESS3",
          "BGOW9068-TM-ADDRESS3"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "PostalCode",
        "displayName": "Postal code",
        "type": "string?",
        "description": "Address postal code.",
        "aliases": [
          "MR-CPOSTAL",
          "BGOW9064-MR-CPOSTAL",
          "POST-CODE",
          "BGOW9068-POST-CODE",
          "AG-POST-CODE",
          "BGOW9068-AG-POST-CODE"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "PostalCodeDescription",
        "displayName": "Postal code description",
        "type": "string?",
        "description": "Address postal-code description.",
        "aliases": [
          "MR-CPOSTAL-DESC",
          "BGOW9064-MR-CPOSTAL-DESC",
          "TM-ADDRESS4",
          "BGOW9068-TM-ADDRESS4"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "CountryCode",
        "displayName": "Country code",
        "type": "string?",
        "description": "Address country code.",
        "aliases": [
          "MR-CPAIS",
          "BGOW9064-MR-CPAIS"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "CountryDescription",
        "displayName": "Country description",
        "type": "string?",
        "description": "Address country description.",
        "aliases": [
          "MR-CPAIS-DESC",
          "BGOW9064-MR-CPAIS-DESC"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "DoorIdentifier",
        "displayName": "Door identifier",
        "type": "string?",
        "description": "Door identifier in the postal/address system.",
        "aliases": [
          "MR-IDP",
          "BGOW9064-MR-IDP",
          "TM-NUM-PORTA",
          "BGOW9068-TM-NUM-PORTA"
        ],
        "tags": [
          "field",
          "address"
        ]
      },
      {
        "name": "DoorTypeCode",
        "displayName": "Door type code",
        "type": "string?",
        "description": "Door type or source-system door identifier category used with the door identifier.",
        "aliases": [
          "TM-TNUM-PORTA",
          "BGOW9068-TM-TNUM-PORTA"
        ],
        "tags": [
          "field",
          "address",
          "copybook:BGOW9068"
        ]
      }
    ]
  },
  {
    "domain": "Payments",
    "name": "AtmPaymentReference",
    "displayName": "ATM payment reference",
    "namespace": "Outputs.Documents.Domain.Common.Payments",
    "file": "Core/src/Outputs.Documents.Domain/Common/Payments/AtmPaymentReference.cs",
    "description": "Reusable Portuguese ATM payment entity and reference block.",
    "aliases": [
      "pagamento atm",
      "entidade referencia"
    ],
    "tags": [
      "common",
      "payment",
      "atm"
    ],
    "properties": [
      {
        "name": "Entity",
        "displayName": "ATM entity",
        "type": "string?",
        "description": "Portuguese ATM payment entity.",
        "aliases": [
          "BGOW0044-ATM-ENTIDADE",
          "ATM-ENTIDADE"
        ],
        "tags": [
          "field",
          "payment",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "Reference",
        "displayName": "ATM reference",
        "type": "string?",
        "description": "Portuguese ATM payment reference.",
        "aliases": [
          "BGOW0044-ATM-REF",
          "ATM-REF"
        ],
        "tags": [
          "field",
          "payment",
          "copybook:BGOW0044"
        ]
      }
    ]
  },
  {
    "domain": "Payments",
    "name": "BankAccount",
    "displayName": "Bank account",
    "namespace": "Outputs.Documents.Domain.Common.Payments",
    "file": "Core/src/Outputs.Documents.Domain/Common/Payments/BankAccount.cs",
    "description": "Reusable SEPA bank-account block with bank name, IBAN, and SWIFT/BIC.",
    "aliases": [
      "conta bancaria",
      "iban",
      "swift",
      "bic",
      "sepa"
    ],
    "tags": [
      "common",
      "banking",
      "payment"
    ],
    "properties": [
      {
        "name": "BankName",
        "displayName": "Bank name",
        "type": "string?",
        "description": "Name of the bank for debit or payment account blocks.",
        "aliases": [
          "BGOW0044-DEB-NOME-BANCO",
          "BGOW0044-CNT-NOME-BANCO",
          "DEB-NOME-BANCO",
          "CNT-NOME-BANCO"
        ],
        "tags": [
          "field",
          "banking",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "Iban",
        "displayName": "IBAN",
        "type": "string?",
        "description": "International bank account number.",
        "aliases": [
          "BGOW0044-DEB-IBAN",
          "BGOW0044-CNT-IBAN",
          "DEB-IBAN",
          "CNT-IBAN"
        ],
        "tags": [
          "field",
          "banking",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "Swift",
        "displayName": "SWIFT",
        "type": "string?",
        "description": "SWIFT or BIC bank identifier.",
        "aliases": [
          "BGOW0044-DEB-SWIFT",
          "BGOW0044-CNT-SWIFT",
          "DEB-SWIFT",
          "CNT-SWIFT"
        ],
        "tags": [
          "field",
          "banking",
          "copybook:BGOW0044"
        ]
      }
    ]
  },
  {
    "domain": "Policies",
    "name": "Coverage",
    "displayName": "Coverage",
    "namespace": "Outputs.Documents.Domain.Common.Policies.Coverages",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/Coverages/Coverage.cs",
    "description": "Reusable insurance coverage block with coverage type, code, description, table type, deductible, indemnity limit, literal text, and capital.",
    "aliases": [
      "coverage",
      "cobertura",
      "COBERTURAS",
      "CB-TIPO-COBERTURA",
      "CB-DESC-COB"
    ],
    "tags": [
      "common",
      "coverage"
    ],
    "properties": [
      {
        "name": "TypeCode",
        "displayName": "Coverage type",
        "type": "string?",
        "description": "Coverage type or level.",
        "aliases": [
          "CB-TIPO-COBERTURA",
          "BGOW9064-CB-TIPO-COBERTURA"
        ],
        "tags": [
          "field",
          "coverage"
        ]
      },
      {
        "name": "Code",
        "displayName": "Coverage code",
        "type": "string?",
        "description": "Coverage code.",
        "aliases": [
          "CB-COD-COB",
          "BGOW9064-CB-COD-COB"
        ],
        "tags": [
          "field",
          "coverage"
        ]
      },
      {
        "name": "Description",
        "displayName": "Coverage description",
        "type": "string?",
        "description": "Coverage description.",
        "aliases": [
          "CB-DESC-COB",
          "BGOW9064-CB-DESC-COB"
        ],
        "tags": [
          "field",
          "coverage"
        ]
      },
      {
        "name": "TableType",
        "displayName": "Coverage table type",
        "type": "string?",
        "description": "Identifier for the table layout used to list the coverage.",
        "aliases": [
          "CB-TIPO-TABELA",
          "BGOW9064-CB-TIPO-TABELA"
        ],
        "tags": [
          "field",
          "coverage"
        ]
      },
      {
        "name": "Deductible",
        "displayName": "Deductible",
        "type": "CoverageDeductible?",
        "description": "Deductible detail for the coverage.",
        "aliases": [
          "CB-FRANQUIA",
          "BGOW9064-CB-FRANQUIA"
        ],
        "tags": [
          "field",
          "coverage",
          "deductible"
        ]
      },
      {
        "name": "DeductibleText",
        "displayName": "Deductible literal",
        "type": "string?",
        "description": "Literal text for the deductible.",
        "aliases": [
          "CB-FRANQUIA-CHAR",
          "BGOW9064-CB-FRANQUIA-CHAR"
        ],
        "tags": [
          "field",
          "coverage",
          "deductible"
        ]
      },
      {
        "name": "InsuredCapital",
        "displayName": "Insured capital",
        "type": "string?",
        "description": "Coverage insured capital amount.",
        "aliases": [
          "CB-VALOR-CAP-SEG",
          "BGOW9064-CB-VALOR-CAP-SEG"
        ],
        "tags": [
          "field",
          "coverage",
          "amount"
        ]
      },
      {
        "name": "TypeCode",
        "displayName": "Deductible type",
        "type": "string?",
        "description": "Deductible type indicator.",
        "aliases": [
          "CB-COD-FRANQUIA",
          "BGOW9064-CB-COD-FRANQUIA"
        ],
        "tags": [
          "field",
          "coverage",
          "deductible"
        ]
      },
      {
        "name": "Value",
        "displayName": "Deductible value",
        "type": "string?",
        "description": "Deductible amount.",
        "aliases": [
          "CB-VALOR-FRANQUIA",
          "BGOW9064-CB-VALOR-FRANQUIA"
        ],
        "tags": [
          "field",
          "coverage",
          "deductible",
          "amount"
        ]
      },
      {
        "name": "MaximumValue",
        "displayName": "Maximum deductible value",
        "type": "string?",
        "description": "Maximum deductible amount.",
        "aliases": [
          "CB-VALOR-MAX-FRANQ",
          "BGOW9064-CB-VALOR-MAX-FRANQ"
        ],
        "tags": [
          "field",
          "coverage",
          "deductible",
          "amount"
        ]
      },
      {
        "name": "Percentage",
        "displayName": "Deductible percentage",
        "type": "string?",
        "description": "Deductible percentage.",
        "aliases": [
          "CB-PERC-FRANQUIA",
          "BGOW9064-CB-PERC-FRANQUIA"
        ],
        "tags": [
          "field",
          "coverage",
          "deductible"
        ]
      },
      {
        "name": "Days",
        "displayName": "Deductible days",
        "type": "string?",
        "description": "Number of deductible days.",
        "aliases": [
          "CB-NUMERO-DIAS",
          "BGOW9064-CB-NUMERO-DIAS"
        ],
        "tags": [
          "field",
          "coverage",
          "deductible"
        ]
      },
      {
        "name": "IndemnityLimitTypeCode",
        "displayName": "Indemnity limit type",
        "type": "string?",
        "description": "Indemnity-limit type indicator.",
        "aliases": [
          "CB-IND-LIM-INDMN",
          "BGOW9064-CB-IND-LIM-INDMN"
        ],
        "tags": [
          "field",
          "coverage",
          "limit"
        ]
      },
      {
        "name": "IndemnityLimitValue",
        "displayName": "Indemnity limit value",
        "type": "string?",
        "description": "Indemnity-limit amount.",
        "aliases": [
          "CB-VALOR-LIM-INDMN",
          "BGOW9064-CB-VALOR-LIM-INDMN"
        ],
        "tags": [
          "field",
          "coverage",
          "limit",
          "amount"
        ]
      },
      {
        "name": "IndemnityLimitPercentage",
        "displayName": "Indemnity limit percentage",
        "type": "string?",
        "description": "Indemnity-limit percentage.",
        "aliases": [
          "CB-PERC-LIM-INDMN",
          "BGOW9064-CB-PERC-LIM-INDMN"
        ],
        "tags": [
          "field",
          "coverage",
          "limit"
        ]
      },
      {
        "name": "IndemnityLimitDays",
        "displayName": "Indemnity limit days",
        "type": "string?",
        "description": "Number of indemnity-limit days.",
        "aliases": [
          "CB-DIAS-LIM-INDMN",
          "BGOW9064-CB-DIAS-LIM-INDMN"
        ],
        "tags": [
          "field",
          "coverage",
          "limit"
        ]
      },
      {
        "name": "AnnualIndemnityLimitValue",
        "displayName": "Annual indemnity limit value",
        "type": "string?",
        "description": "Annual indemnity-limit amount.",
        "aliases": [
          "CB-VLR1-LIM-INDMN",
          "BGOW9064-CB-VLR1-LIM-INDMN"
        ],
        "tags": [
          "field",
          "coverage",
          "limit",
          "amount"
        ]
      }
    ]
  },
  {
    "domain": "Policies",
    "name": "Policy",
    "displayName": "Insurance policy",
    "namespace": "Outputs.Documents.Domain.Common.Policies",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/Policy.cs",
    "description": "Reusable insurance policy block for policy number, policy transaction, and product information sent by document copybooks.",
    "aliases": [
      "policy",
      "apolice",
      "POLICY-NUMBER",
      "POLICY-TRANSACTION",
      "NR-APOLICE"
    ],
    "tags": [
      "common",
      "policy",
      "insurance"
    ],
    "properties": [
      {
        "name": "Number",
        "displayName": "Policy number",
        "type": "string?",
        "description": "Insurance policy number.",
        "aliases": [
          "POLICY-NUMBER",
          "BGOW9068-POLICY-NUMBER",
          "NR-APOLICE",
          "BGOW9064-NR-APOLICE"
        ],
        "tags": [
          "field",
          "policy"
        ]
      },
      {
        "name": "TransactionCode",
        "displayName": "Policy transaction code",
        "type": "string?",
        "description": "Policy transaction code that identifies the policy operation represented by the document.",
        "aliases": [
          "POLICY-TRANSACTION",
          "BGOW9068-POLICY-TRANSACTION"
        ],
        "tags": [
          "field",
          "policy",
          "copybook:BGOW9068"
        ]
      },
      {
        "name": "Product",
        "displayName": "Product",
        "type": "ProductReference",
        "description": "Insurance product and branch information associated with the policy.",
        "aliases": [
          "PRODUTO",
          "BGOW9068-PRODUTO",
          "PRODUCT",
          "BGOW9068-PRODUCT",
          "COD-PRODUTO",
          "BGOW0044-COD-PRODUTO"
        ],
        "tags": [
          "field",
          "policy",
          "product"
        ]
      }
    ]
  },
  {
    "domain": "Policies",
    "name": "PolicyReference",
    "displayName": "Policy reference",
    "namespace": "Outputs.Documents.Domain.Common.Policies",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/PolicyReference.cs",
    "description": "Reusable insurance policy reference block with client, policy, company, brand, origin system, and agent identifiers.",
    "aliases": [
      "apolice",
      "policy",
      "numero apolice",
      "cliente",
      "mediador"
    ],
    "tags": [
      "common",
      "policy",
      "reference"
    ],
    "properties": [
      {
        "name": "CompanyCode",
        "displayName": "Company code",
        "type": "string?",
        "description": "Company identifier.",
        "aliases": [
          "BGOW0044-COD-COMPANHIA",
          "COD-COMPANHIA"
        ],
        "tags": [
          "field",
          "policy",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "BrandCode",
        "displayName": "Brand code",
        "type": "string?",
        "description": "Brand identifier.",
        "aliases": [
          "BGOW0044-COD-MARCA",
          "COD-MARCA"
        ],
        "tags": [
          "field",
          "policy",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "BrandAuxiliaryCode",
        "displayName": "Brand auxiliary code",
        "type": "string?",
        "description": "Auxiliary brand indicator.",
        "aliases": [
          "BGOW0044-AUX-MARCA",
          "AUX-MARCA"
        ],
        "tags": [
          "field",
          "policy",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "AgentNumber",
        "displayName": "Agent number",
        "type": "string?",
        "description": "Agent or mediator number.",
        "aliases": [
          "BGOW0044-NR-AGENTE",
          "NR-AGENTE"
        ],
        "tags": [
          "field",
          "policy",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "ClientNumber",
        "displayName": "Client number",
        "type": "string?",
        "description": "Client number.",
        "aliases": [
          "BGOW0044-NR-CLIENTE",
          "NR-CLIENTE"
        ],
        "tags": [
          "field",
          "policy",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "PolicyNumber",
        "displayName": "Policy number",
        "type": "string?",
        "description": "Policy number.",
        "aliases": [
          "BGOW0044-NR-APOLICE",
          "NR-APOLICE"
        ],
        "tags": [
          "field",
          "policy",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "OriginSystemCode",
        "displayName": "Origin system code",
        "type": "string?",
        "description": "Origin system identifier.",
        "aliases": [
          "BGOW0044-COD-ORIGEM",
          "COD-ORIGEM"
        ],
        "tags": [
          "field",
          "policy",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "FlyerIndicator",
        "displayName": "Flyer indicator",
        "type": "string?",
        "description": "Flyer inclusion indicator.",
        "aliases": [
          "BGOW0044-IND-FLYER",
          "IND-FLYER"
        ],
        "tags": [
          "field",
          "policy",
          "copybook:BGOW0044"
        ]
      }
    ]
  },
  {
    "domain": "Policies",
    "name": "Premium",
    "displayName": "Premium",
    "namespace": "Outputs.Documents.Domain.Common.Policies",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/Premium.cs",
    "description": "Reusable premium and charge breakdown with commercial premium, fees, totals, additional values, first fraction, and following fractions.",
    "aliases": [
      "premium",
      "premio",
      "DADOS-VALOR",
      "DV-PREMIO-COM",
      "DV-PREMIO-TOT"
    ],
    "tags": [
      "common",
      "premium",
      "amount"
    ],
    "properties": [
      {
        "name": "Commercial",
        "displayName": "Commercial premium",
        "type": "string?",
        "description": "Commercial premium amount.",
        "aliases": [
          "DV-PREMIO-COM",
          "BGOW9064-DV-PREMIO-COM"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "Charges",
        "displayName": "Charges",
        "type": "string?",
        "description": "Fiscal and parafiscal charges.",
        "aliases": [
          "DV-ENCARGOS",
          "BGOW9064-DV-ENCARGOS"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "Total",
        "displayName": "Total premium",
        "type": "string?",
        "description": "Total premium amount.",
        "aliases": [
          "DV-PREMIO-TOT",
          "BGOW9064-DV-PREMIO-TOT"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "AdditionalCommercial",
        "displayName": "Additional commercial premium",
        "type": "string?",
        "description": "Additional commercial premium amount.",
        "aliases": [
          "DV-PREMIO-COM-AD",
          "BGOW9064-DV-PREMIO-COM-AD"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "AdditionalCharges",
        "displayName": "Additional charges",
        "type": "string?",
        "description": "Additional fiscal and parafiscal charges.",
        "aliases": [
          "DV-ENCARGOS-AD",
          "BGOW9064-DV-ENCARGOS-AD"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "AdditionalTotal",
        "displayName": "Additional total premium",
        "type": "string?",
        "description": "Additional total premium amount.",
        "aliases": [
          "DV-PREMIO-TOT-AD",
          "BGOW9064-DV-PREMIO-TOT-AD"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "FirstFractionCommercial",
        "displayName": "First fraction commercial premium",
        "type": "string?",
        "description": "Commercial premium amount for the first fraction.",
        "aliases": [
          "DV-PREMIO-COM-1F",
          "BGOW9064-DV-PREMIO-COM-1F"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "FirstFractionCharges",
        "displayName": "First fraction charges",
        "type": "string?",
        "description": "Charges amount for the first fraction.",
        "aliases": [
          "DV-ENCARGOS-1F",
          "BGOW9064-DV-ENCARGOS-1F"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "FirstFractionTotal",
        "displayName": "First fraction total premium",
        "type": "string?",
        "description": "Total premium amount for the first fraction.",
        "aliases": [
          "DV-PREMIO-TOT-1F",
          "BGOW9064-DV-PREMIO-TOT-1F"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "FollowingFractionsCommercial",
        "displayName": "Following fractions commercial premium",
        "type": "string?",
        "description": "Commercial premium amount for following fractions.",
        "aliases": [
          "DV-PREMIO-COM-FS",
          "BGOW9064-DV-PREMIO-COM-FS"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "FollowingFractionsCharges",
        "displayName": "Following fractions charges",
        "type": "string?",
        "description": "Charges amount for following fractions.",
        "aliases": [
          "DV-ENCARGOS-FS",
          "BGOW9064-DV-ENCARGOS-FS"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      },
      {
        "name": "FollowingFractionsTotal",
        "displayName": "Following fractions total premium",
        "type": "string?",
        "description": "Total premium amount for following fractions.",
        "aliases": [
          "DV-PREMIO-TOT-FS",
          "BGOW9064-DV-PREMIO-TOT-FS"
        ],
        "tags": [
          "field",
          "premium",
          "amount"
        ]
      }
    ]
  },
  {
    "domain": "Policies",
    "name": "ProductReference",
    "displayName": "Product reference",
    "namespace": "Outputs.Documents.Domain.Common.Policies",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/ProductReference.cs",
    "description": "Reusable insurance product and branch reference block.",
    "aliases": [
      "produto",
      "ramo",
      "ramo produto",
      "moeda",
      "PRODUTO",
      "PRODUCT"
    ],
    "tags": [
      "common",
      "policy",
      "product"
    ],
    "properties": [
      {
        "name": "CurrencyCode",
        "displayName": "Currency code",
        "type": "string?",
        "description": "Currency code.",
        "aliases": [
          "BGOW0044-COD-MOEDA",
          "COD-MOEDA"
        ],
        "tags": [
          "field",
          "product",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "ProductCode",
        "displayName": "Product code",
        "type": "string?",
        "description": "Insurance product code.",
        "aliases": [
          "BGOW0044-COD-PRODUTO",
          "COD-PRODUTO",
          "BGOW9068-PRODUTO",
          "PRODUTO"
        ],
        "tags": [
          "field",
          "product",
          "copybook:BGOW0044",
          "copybook:BGOW9068"
        ]
      },
      {
        "name": "BranchCode",
        "displayName": "Branch code",
        "type": "string?",
        "description": "Insurance branch code.",
        "aliases": [
          "BGOW0044-COD-RAMO",
          "COD-RAMO"
        ],
        "tags": [
          "field",
          "product",
          "copybook:BGOW0044"
        ]
      },
      {
        "name": "BranchProductDescription",
        "displayName": "Branch product description",
        "type": "string?",
        "description": "Branch and product description.",
        "aliases": [
          "BGOW0044-DESCR-RAMO-PROD",
          "DESCR-RAMO-PROD",
          "BGOW9068-PRODUCT",
          "PRODUCT"
        ],
        "tags": [
          "field",
          "product",
          "copybook:BGOW0044",
          "copybook:BGOW9068"
        ]
      }
    ]
  },
  {
    "domain": "Policy risks",
    "name": "GarageRiskDetail",
    "displayName": "Garage risk detail",
    "namespace": "Outputs.Documents.Domain.Common.Policies.Risks",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/Risks/GarageRiskDetail.cs",
    "description": "Garage automobile risk detail with driving license and category description.",
    "aliases": [
      "garagista",
      "carta conducao",
      "categoria"
    ],
    "tags": [
      "common",
      "risk",
      "vehicle"
    ],
    "properties": []
  },
  {
    "domain": "Policy risks",
    "name": "GeneralRiskDetail",
    "displayName": "General risk detail",
    "namespace": "Outputs.Documents.Domain.Common.Policies.Risks",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/Risks/GeneralRiskDetail.cs",
    "description": "Generic insured object or risk-unit description for risks without a specialized shape.",
    "aliases": [
      "detalhe geral",
      "objeto seguro"
    ],
    "tags": [
      "common",
      "risk"
    ],
    "properties": []
  },
  {
    "domain": "Policy risks",
    "name": "HealthRiskDetail",
    "displayName": "Health risk detail",
    "namespace": "Outputs.Documents.Domain.Common.Policies.Risks",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/Risks/HealthRiskDetail.cs",
    "description": "Health risk detail with insured person and intervention capital.",
    "aliases": [
      "saude",
      "capital inter",
      "pessoa segura"
    ],
    "tags": [
      "common",
      "risk",
      "health"
    ],
    "properties": []
  },
  {
    "domain": "Policy risks",
    "name": "LifeRiskDetail",
    "displayName": "Life risk detail",
    "namespace": "Outputs.Documents.Domain.Common.Policies.Risks",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/Risks/LifeRiskDetail.cs",
    "description": "Risk detail with up to two insured people for life-risk products.",
    "aliases": [
      "vida risco",
      "pessoa segura"
    ],
    "tags": [
      "common",
      "risk",
      "life"
    ],
    "properties": []
  },
  {
    "domain": "Policy risks",
    "name": "PropertyRiskDetail",
    "displayName": "Property risk detail",
    "namespace": "Outputs.Documents.Domain.Common.Policies.Risks",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/Risks/PropertyRiskDetail.cs",
    "description": "Multi-risk property detail with object code and risk location address.",
    "aliases": [
      "multirisco",
      "imovel",
      "morada risco"
    ],
    "tags": [
      "common",
      "risk",
      "property",
      "address"
    ],
    "properties": []
  },
  {
    "domain": "Policy risks",
    "name": "RiskUnit",
    "displayName": "Risk unit",
    "namespace": "Outputs.Documents.Domain.Common.Policies.Risks",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/Risks/RiskUnit.cs",
    "description": "Reusable insured object or risk-unit block. The detail shape depends on risk unit type.",
    "aliases": [
      "unidade em risco",
      "objeto seguro",
      "risk unit"
    ],
    "tags": [
      "common",
      "risk",
      "insured-object"
    ],
    "properties": [
      {
        "name": "Description",
        "displayName": "Risk description",
        "type": "string?",
        "description": "Insured object or risk-unit description.",
        "aliases": [
          "OS-OBJECTO-SEG",
          "DO-OBJETO-SEG",
          "BGOW9064-OS-OBJECTO-SEG",
          "BGOW9064-DO-OBJETO-SEG"
        ],
        "tags": [
          "field",
          "risk"
        ]
      },
      {
        "name": "RiskLocationLine1",
        "displayName": "Risk location line 1",
        "type": "string?",
        "description": "First risk location line.",
        "aliases": [
          "OS-LOCAL-RISC1",
          "BGOW9064-OS-LOCAL-RISC1"
        ],
        "tags": [
          "field",
          "risk",
          "address"
        ]
      },
      {
        "name": "RiskLocationLine2",
        "displayName": "Risk location line 2",
        "type": "string?",
        "description": "Second risk location line.",
        "aliases": [
          "OS-LOCAL-RISC2",
          "BGOW9064-OS-LOCAL-RISC2"
        ],
        "tags": [
          "field",
          "risk",
          "address"
        ]
      },
      {
        "name": "RiskLocationDescription",
        "displayName": "Risk location description",
        "type": "string?",
        "description": "Detailed risk location description.",
        "aliases": [
          "DO-LOCAL-RISC",
          "BGOW9064-DO-LOCAL-RISC"
        ],
        "tags": [
          "field",
          "risk",
          "address"
        ]
      },
      {
        "name": "InsuredCapital",
        "displayName": "Insured capital",
        "type": "string?",
        "description": "Risk or insured-object capital amount.",
        "aliases": [
          "OS-CAPITAL-SEG",
          "BGOW9064-OS-CAPITAL-SEG"
        ],
        "tags": [
          "field",
          "risk",
          "amount"
        ]
      },
      {
        "name": "ProductDescription",
        "displayName": "Product description",
        "type": "string?",
        "description": "Product description related to the risk unit.",
        "aliases": [
          "DO-PRODUTO",
          "BGOW9064-DO-PRODUTO"
        ],
        "tags": [
          "field",
          "risk",
          "product"
        ]
      },
      {
        "name": "PolicyNumber",
        "displayName": "Policy number",
        "type": "string?",
        "description": "Policy number related to the risk unit.",
        "aliases": [
          "DO-APOLICE",
          "BGOW9064-DO-APOLICE"
        ],
        "tags": [
          "field",
          "risk",
          "policy"
        ]
      },
      {
        "name": "ActivityDescription",
        "displayName": "Activity description",
        "type": "string?",
        "description": "Activity description related to the risk unit.",
        "aliases": [
          "DO-ACTIVIDADE",
          "BGOW9064-DO-ACTIVIDADE"
        ],
        "tags": [
          "field",
          "risk"
        ]
      },
      {
        "name": "ModalityDescription",
        "displayName": "Modality description",
        "type": "string?",
        "description": "Modality description related to the risk unit.",
        "aliases": [
          "DO-MODALIDADE",
          "BGOW9064-DO-MODALIDADE"
        ],
        "tags": [
          "field",
          "risk"
        ]
      },
      {
        "name": "CoverageScopeDescription",
        "displayName": "Coverage scope description",
        "type": "string?",
        "description": "Coverage scope description related to the risk unit.",
        "aliases": [
          "DO-AMBITO-COB",
          "BGOW9064-DO-AMBITO-COB"
        ],
        "tags": [
          "field",
          "risk",
          "coverage"
        ]
      },
      {
        "name": "WorkerCount",
        "displayName": "Worker count",
        "type": "string?",
        "description": "Number of workers related to the risk unit.",
        "aliases": [
          "DO-NR-TRABALH",
          "BGOW9064-DO-NR-TRABALH"
        ],
        "tags": [
          "field",
          "risk"
        ]
      }
    ]
  },
  {
    "domain": "Policy risks",
    "name": "VehicleRiskDetail",
    "displayName": "Vehicle risk detail",
    "namespace": "Outputs.Documents.Domain.Common.Policies.Risks",
    "file": "Core/src/Outputs.Documents.Domain/Common/Policies/Risks/VehicleRiskDetail.cs",
    "description": "Automobile vehicle detail with brand, model, version, and registration number.",
    "aliases": [
      "automovel",
      "veiculo",
      "marca",
      "modelo",
      "matricula"
    ],
    "tags": [
      "common",
      "risk",
      "vehicle"
    ],
    "properties": []
  }
];
