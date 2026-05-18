window.MIGRATION_MAPS = [
  {
    "copybook": "BGOW0010",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0010 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.BGOW0010Contract",
    "description": "BGOW0010 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0010Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0010 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1101",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1101."
          },
          {
            "source": null,
            "sourceField": "1102",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1102."
          },
          {
            "source": null,
            "sourceField": "1103",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1103."
          },
          {
            "source": null,
            "sourceField": "1104",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1104."
          },
          {
            "source": null,
            "sourceField": "1105",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1105."
          },
          {
            "source": null,
            "sourceField": "1106",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1106."
          },
          {
            "source": null,
            "sourceField": "1107",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1107."
          },
          {
            "source": null,
            "sourceField": "1108",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1108."
          },
          {
            "source": null,
            "sourceField": "1109",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1109."
          },
          {
            "source": null,
            "sourceField": "1110",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1110."
          },
          {
            "source": null,
            "sourceField": "1111",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1111."
          },
          {
            "source": null,
            "sourceField": "1112",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1112."
          },
          {
            "source": null,
            "sourceField": "1113",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1113."
          },
          {
            "source": null,
            "sourceField": "1114",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1114."
          },
          {
            "source": null,
            "sourceField": "1115",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1115."
          },
          {
            "source": null,
            "sourceField": "1116",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1116."
          },
          {
            "source": null,
            "sourceField": "1128",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1128."
          },
          {
            "source": null,
            "sourceField": "1129",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1129."
          },
          {
            "source": null,
            "sourceField": "1131",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1131."
          },
          {
            "source": null,
            "sourceField": "1132",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1132."
          },
          {
            "source": null,
            "sourceField": "1151",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1151."
          },
          {
            "source": null,
            "sourceField": "1152",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1152."
          },
          {
            "source": null,
            "sourceField": "1153",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1153."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-DOCUMENTO / TIPO-IMPRESSAO / USERID / COD-COMPANHIA",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-DOCUMENTO            PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentInformation.CodDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USERID                   PIC X(08).",
            "sourceField": "USERID",
            "target": "DocumentInformation.Userid",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-AUX-MARCA                PIC X(01).",
            "sourceField": "AUX-MARCA",
            "target": "DocumentInformation.AuxMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "DocumentInformation.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-IND-FLYER                PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "DocumentInformation.IndFlyer",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TIPO-DOCUMENTO         PIC X(01).",
            "sourceField": "TIPO-DOCUMENTO",
            "target": "DocumentInformation.TipoDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-PRODUTO            PIC X(10).",
            "sourceField": "COD-PRODUTO",
            "target": "DocumentInformation.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VH-MARCA             PIC X(30).",
            "sourceField": "VH-MARCA",
            "target": "DocumentInformation.VhMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-NR-APOLICE          PIC X(16).",
            "sourceField": "TA-NR-APOLICE",
            "target": "DocumentInformation.TaNrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-COD-PRODUTO         PIC X(10).",
            "sourceField": "TA-COD-PRODUTO",
            "target": "DocumentInformation.TaCodProduto",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-MOEDA / COD-PRODUTO / COD-RAMO",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-MOEDA              PIC X(03).",
            "sourceField": "COD-MOEDA",
            "target": "Policy.CodMoeda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-PRODUTO            PIC X(10).",
            "sourceField": "COD-PRODUTO",
            "target": "Policy.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-RAMO               PIC X(10).",
            "sourceField": "COD-RAMO",
            "target": "Policy.CodRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DESCR-RAMO-PROD        PIC X(40).",
            "sourceField": "DESCR-RAMO-PROD",
            "target": "Policy.DescrRamoProd",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-POU-APOLICE          PIC X(16).",
            "sourceField": "POU-APOLICE",
            "target": "Policy.PouApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VI-TIPO-APOLICE        PIC X(02).",
            "sourceField": "VI-TIPO-APOLICE",
            "target": "Policy.ViTipoApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-ADERENTE            PIC X(08).",
            "sourceField": "PS-ADERENTE",
            "target": "Policy.PsAderente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PI-POLICY-BUS-COUNTRY  PIC X(03).",
            "sourceField": "PI-POLICY-BUS-COUNTRY",
            "target": "Policy.PiPolicyBusCountry",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-NR-APOLICE          PIC X(16).",
            "sourceField": "TA-NR-APOLICE",
            "target": "Policy.TaNrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-COD-PRODUTO         PIC X(10).",
            "sourceField": "TA-COD-PRODUTO",
            "target": "Policy.TaCodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-COD-RAMO            PIC X(10).",
            "sourceField": "TA-COD-RAMO",
            "target": "Policy.TaCodRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-DESCR-RAMO-PROD     PIC X(40).",
            "sourceField": "TA-DESCR-RAMO-PROD",
            "target": "Policy.TaDescrRamoProd",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-VI-TIPO-APOLICE     PIC X(02).",
            "sourceField": "TA-VI-TIPO-APOLICE",
            "target": "Policy.TaViTipoApolice",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "NR-CLIENTE / CL-NOME / CL-LOCATION-REF / CL-MORADA1",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NOME                PIC X(40).",
            "sourceField": "CL-NOME",
            "target": "Client.ClNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "Client.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "Client.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "Client.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "Client.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "Client.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "Client.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS               PIC X(03).",
            "sourceField": "CL-CPAIS",
            "target": "Client.ClCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS-DESC          PIC X(40).",
            "sourceField": "CL-CPAIS-DESC",
            "target": "Client.ClCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-IDP                 PIC X(04).",
            "sourceField": "CL-IDP",
            "target": "Client.ClIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NIF                 PIC X(22).",
            "sourceField": "CL-NIF",
            "target": "Client.ClNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-TIPO-ENTIDADE       PIC X(01).",
            "sourceField": "CL-TIPO-ENTIDADE",
            "target": "Client.ClTipoEntidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CTT-CLIENTE          PIC X(03).",
            "sourceField": "CTT-CLIENTE",
            "target": "Client.CttCliente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "NR-AGENTE / AG-NOME / AG-LOCATION-REF / AG-MORADA1",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.Agent",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "Agent.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-NOME                PIC X(40).",
            "sourceField": "AG-NOME",
            "target": "Agent.AgNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-LOCATION-REF        PIC X(04).",
            "sourceField": "AG-LOCATION-REF",
            "target": "Agent.AgLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-MORADA1             PIC X(40).",
            "sourceField": "AG-MORADA1",
            "target": "Agent.AgMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-MORADA2             PIC X(40).",
            "sourceField": "AG-MORADA2",
            "target": "Agent.AgMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-LOCALIDADE          PIC X(40).",
            "sourceField": "AG-LOCALIDADE",
            "target": "Agent.AgLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPOSTAL             PIC X(09).",
            "sourceField": "AG-CPOSTAL",
            "target": "Agent.AgCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "AG-CPOSTAL-DESC",
            "target": "Agent.AgCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPAIS               PIC X(03).",
            "sourceField": "AG-CPAIS",
            "target": "Agent.AgCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPAIS-DESC          PIC X(40).",
            "sourceField": "AG-CPAIS-DESC",
            "target": "Agent.AgCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-IDP                 PIC X(04).",
            "sourceField": "AG-IDP",
            "target": "Agent.AgIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-TELEFONE            PIC X(16).",
            "sourceField": "AG-TELEFONE",
            "target": "Agent.AgTelefone",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-TELEMOVEL           PIC X(16).",
            "sourceField": "AG-TELEMOVEL",
            "target": "Agent.AgTelemovel",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-EMAIL               PIC X(60).",
            "sourceField": "AG-EMAIL",
            "target": "Agent.AgEmail",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-NR-CNT-VENDA        PIC X(10).",
            "sourceField": "AG-NR-CNT-VENDA",
            "target": "Agent.AgNrCntVenda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-VLR-CNT-VENDA       PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "AG-VLR-CNT-VENDA",
            "target": "Agent.AgVlrCntVenda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-NR-CNT-COBRA        PIC X(10).",
            "sourceField": "AG-NR-CNT-COBRA",
            "target": "Agent.AgNrCntCobra",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-VLR-CNT-COBRA       PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "AG-VLR-CNT-COBRA",
            "target": "Agent.AgVlrCntCobra",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Creditor",
        "sourceGroup": "CH-QUANT / CH-NUMBER / CH-NOME / CH-LOCATION-REF",
        "targetType": "Entity?",
        "targetPath": "Creditor",
        "decision": "mapped",
        "description": "Optional creditor or mortgage creditor party identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.Creditor",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-CH-QUANT               PIC 9(05).",
            "sourceField": "CH-QUANT",
            "target": "Creditor.ChQuant",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-NUMBER              PIC X(10).",
            "sourceField": "CH-NUMBER",
            "target": "Creditor.ChNumber",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-NOME                PIC X(40).",
            "sourceField": "CH-NOME",
            "target": "Creditor.ChNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-LOCATION-REF        PIC X(04).",
            "sourceField": "CH-LOCATION-REF",
            "target": "Creditor.ChLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-MORADA1             PIC X(40).",
            "sourceField": "CH-MORADA1",
            "target": "Creditor.ChMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-MORADA2             PIC X(40).",
            "sourceField": "CH-MORADA2",
            "target": "Creditor.ChMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-LOCALIDADE          PIC X(40).",
            "sourceField": "CH-LOCALIDADE",
            "target": "Creditor.ChLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-CPOSTAL             PIC X(09).",
            "sourceField": "CH-CPOSTAL",
            "target": "Creditor.ChCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CH-CPOSTAL-DESC",
            "target": "Creditor.ChCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-CPAIS               PIC X(03).",
            "sourceField": "CH-CPAIS",
            "target": "Creditor.ChCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-CPAIS-DESC          PIC X(40).",
            "sourceField": "CH-CPAIS-DESC",
            "target": "Creditor.ChCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-IDP                 PIC X(04).",
            "sourceField": "CH-IDP",
            "target": "Creditor.ChIdp",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "CL-LOCATION-REF / CL-MORADA1 / CL-MORADA2 / CL-LOCALIDADE",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "MailingAddress.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "MailingAddress.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "MailingAddress.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "MailingAddress.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "MailingAddress.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "MailingAddress.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-LOCATION-REF        PIC X(04).",
            "sourceField": "AG-LOCATION-REF",
            "target": "MailingAddress.AgLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-MORADA1             PIC X(40).",
            "sourceField": "AG-MORADA1",
            "target": "MailingAddress.AgMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-MORADA2             PIC X(40).",
            "sourceField": "AG-MORADA2",
            "target": "MailingAddress.AgMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-LOCALIDADE          PIC X(40).",
            "sourceField": "AG-LOCALIDADE",
            "target": "MailingAddress.AgLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPOSTAL             PIC X(09).",
            "sourceField": "AG-CPOSTAL",
            "target": "MailingAddress.AgCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "AG-CPOSTAL-DESC",
            "target": "MailingAddress.AgCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-LOCATION-REF        PIC X(04).",
            "sourceField": "CH-LOCATION-REF",
            "target": "MailingAddress.ChLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-MORADA1             PIC X(40).",
            "sourceField": "CH-MORADA1",
            "target": "MailingAddress.ChMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-MORADA2             PIC X(40).",
            "sourceField": "CH-MORADA2",
            "target": "MailingAddress.ChMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-LOCALIDADE          PIC X(40).",
            "sourceField": "CH-LOCALIDADE",
            "target": "MailingAddress.ChLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-CPOSTAL             PIC X(09).",
            "sourceField": "CH-CPOSTAL",
            "target": "MailingAddress.ChCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CH-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CH-CPOSTAL-DESC",
            "target": "MailingAddress.ChCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "PaymentAccount",
        "sourceGroup": "DEB-NOME-BANCO / DEB-IBAN / DEB-SWIFT / DEB-ID-CREDOR",
        "targetType": "BankAccount?",
        "targetPath": "PaymentAccount",
        "decision": "mapped",
        "description": "Bank-account payment details identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.PaymentAccount",
            "status": "container"
          },
          {
            "source": "11  :PREFIX:-DEB-NOME-BANCO       PIC X(60).",
            "sourceField": "DEB-NOME-BANCO",
            "target": "PaymentAccount.DebNomeBanco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-DEB-IBAN             PIC X(34).",
            "sourceField": "DEB-IBAN",
            "target": "PaymentAccount.DebIban",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-DEB-SWIFT            PIC X(11).",
            "sourceField": "DEB-SWIFT",
            "target": "PaymentAccount.DebSwift",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-DEB-ID-CREDOR        PIC X(35).",
            "sourceField": "DEB-ID-CREDOR",
            "target": "PaymentAccount.DebIdCredor",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-DEB-ADD              PIC X(11).",
            "sourceField": "DEB-ADD",
            "target": "PaymentAccount.DebAdd",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "AtmPayment",
        "sourceGroup": "ATM-ENTIDADE / ATM-REF",
        "targetType": "AtmPaymentReference?",
        "targetPath": "AtmPayment",
        "decision": "mapped",
        "description": "ATM payment entity/reference details identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.AtmPayment",
            "status": "container"
          },
          {
            "source": "11  :PREFIX:-ATM-ENTIDADE         PIC X(05).",
            "sourceField": "ATM-ENTIDADE",
            "target": "AtmPayment.AtmEntidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-ATM-REF              PIC X(09).",
            "sourceField": "ATM-REF",
            "target": "AtmPayment.AtmRef",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "VLR-CAPITAL-RECIBO / VLR-PREMIO-RISCO / VLR-BONIFICACAO / VLR-TOTAL-RECIBO",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-VLR-CAPITAL-RECIBO     PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-CAPITAL-RECIBO",
            "target": "Premium.VlrCapitalRecibo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-PREMIO-RISCO       PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-PREMIO-RISCO",
            "target": "Premium.VlrPremioRisco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-BONIFICACAO        PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-BONIFICACAO",
            "target": "Premium.VlrBonificacao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-TOTAL-RECIBO       PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-TOTAL-RECIBO",
            "target": "Premium.VlrTotalRecibo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FRACC              PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FRACC",
            "target": "Premium.VlrFracc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FAT                PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FAT",
            "target": "Premium.VlrFat",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FGA                PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FGA",
            "target": "Premium.VlrFga",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-SNB                PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-SNB",
            "target": "Premium.VlrSnb",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-INEM               PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-INEM",
            "target": "Premium.VlrInem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-CVERDE             PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-CVERDE",
            "target": "Premium.VlrCverde",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-SELOS              PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-SELOS",
            "target": "Premium.VlrSelos",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-ACTA               PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-ACTA",
            "target": "Premium.VlrActa",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-IMP-SELO           PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-IMP-SELO",
            "target": "Premium.VlrImpSelo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FUND-CALAM         PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FUND-CALAM",
            "target": "Premium.VlrFundCalam",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FGA-OCOBERT        PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FGA-OCOBERT",
            "target": "Premium.VlrFgaOcobert",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FGA-RCIVIL         PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FGA-RCIVIL",
            "target": "Premium.VlrFgaRcivil",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-BONUS              PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-BONUS",
            "target": "Premium.VlrBonus",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-PR-SIMPLES         PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-PR-SIMPLES",
            "target": "Premium.VlrPrSimples",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "RiskUnit",
        "sourceGroup": "VLR-PREMIO-RISCO / UR-QUANT / UR-TIPO / PS-1-NOME",
        "targetType": "RiskUnit",
        "targetPath": "RiskUnit",
        "decision": "mapped",
        "description": "Insured object, insured person, or risk-unit data identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.RiskUnit",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-VLR-PREMIO-RISCO       PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-PREMIO-RISCO",
            "target": "RiskUnit.VlrPremioRisco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-UR-QUANT               PIC 9(05).",
            "sourceField": "UR-QUANT",
            "target": "RiskUnit.UrQuant",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-UR-TIPO                PIC X(02).",
            "sourceField": "UR-TIPO",
            "target": "RiskUnit.UrTipo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-1-NOME              PIC X(50).",
            "sourceField": "PS-1-NOME",
            "target": "RiskUnit.Ps1Nome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-1-NIF               PIC X(22).",
            "sourceField": "PS-1-NIF",
            "target": "RiskUnit.Ps1Nif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-1-DT-NASC           PIC X(08).",
            "sourceField": "PS-1-DT-NASC",
            "target": "RiskUnit.Ps1DtNasc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-2-NOME              PIC X(50).",
            "sourceField": "PS-2-NOME",
            "target": "RiskUnit.Ps2Nome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-2-NIF               PIC X(22).",
            "sourceField": "PS-2-NIF",
            "target": "RiskUnit.Ps2Nif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-2-DT-NASC           PIC X(08).",
            "sourceField": "PS-2-DT-NASC",
            "target": "RiskUnit.Ps2DtNasc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VH-MARCA             PIC X(30).",
            "sourceField": "VH-MARCA",
            "target": "RiskUnit.VhMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VH-MODELO            PIC X(10).",
            "sourceField": "VH-MODELO",
            "target": "RiskUnit.VhModelo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VH-VERSAO            PIC X(25).",
            "sourceField": "VH-VERSAO",
            "target": "RiskUnit.VhVersao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VH-MATRICULA         PIC X(15).",
            "sourceField": "VH-MATRICULA",
            "target": "RiskUnit.VhMatricula",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VG-CARTA-COND        PIC X(25).",
            "sourceField": "VG-CARTA-COND",
            "target": "RiskUnit.VgCartaCond",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VG-CATEGORIA         PIC X(40).",
            "sourceField": "VG-CATEGORIA",
            "target": "RiskUnit.VgCategoria",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VO-OBJETO            PIC X(65).",
            "sourceField": "VO-OBJETO",
            "target": "RiskUnit.VoObjeto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MR-OBJETO              PIC X(10).",
            "sourceField": "MR-OBJETO",
            "target": "RiskUnit.MrObjeto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MR-MORADA1             PIC X(40).",
            "sourceField": "MR-MORADA1",
            "target": "RiskUnit.MrMorada1",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "TextBlocks",
        "sourceGroup": "MR-IND-TEXT-FRENT / MR-IND-TEXT-VERSO / MR-TEXT-FRENT / AT-IND-TEXT-FRENT",
        "targetType": "IReadOnlyList<TextBlock>",
        "targetPath": "TextBlocks",
        "decision": "candidate",
        "description": "Document text, notes, clauses, or message lines identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.TextBlocks",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-MR-IND-TEXT-FRENT      PIC X(01).",
            "sourceField": "MR-IND-TEXT-FRENT",
            "target": "TextBlocks.MrIndTextFrent",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-MR-IND-TEXT-VERSO      PIC X(02).",
            "sourceField": "MR-IND-TEXT-VERSO",
            "target": "TextBlocks.MrIndTextVerso",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-MR-TEXT-FRENT          PIC X(60).",
            "sourceField": "MR-TEXT-FRENT",
            "target": "TextBlocks.MrTextFrent",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-AT-IND-TEXT-FRENT      PIC X(01).",
            "sourceField": "AT-IND-TEXT-FRENT",
            "target": "TextBlocks.AtIndTextFrent",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-AT-TEXT-FRENT          PIC X(60).",
            "sourceField": "AT-TEXT-FRENT",
            "target": "TextBlocks.AtTextFrent",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-MS-INDIC-MENSAGENS     PIC X(01).",
            "sourceField": "MS-INDIC-MENSAGENS",
            "target": "TextBlocks.MsIndicMensagens",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-NC-IND-NOTA-ADIC       PIC X(01).",
            "sourceField": "NC-IND-NOTA-ADIC",
            "target": "TextBlocks.NcIndNotaAdic",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0010."
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-INI-RECI / DT-FIM-RECI / DT-CRI-RECI / DT-LIM-PAG",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-INI-RECI            PIC X(08).",
            "sourceField": "DT-INI-RECI",
            "target": "Tables.DtIniReci",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-DT-FIM-RECI            PIC X(08).",
            "sourceField": "DT-FIM-RECI",
            "target": "Tables.DtFimReci",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-DT-CRI-RECI            PIC X(08).",
            "sourceField": "DT-CRI-RECI",
            "target": "Tables.DtCriReci",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-DT-LIM-PAG             PIC X(08).",
            "sourceField": "DT-LIM-PAG",
            "target": "Tables.DtLimPag",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-DT-LIM-DEVOL           PIC X(08).",
            "sourceField": "DT-LIM-DEVOL",
            "target": "Tables.DtLimDevol",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-DT-CESSACAO            PIC X(08).",
            "sourceField": "DT-CESSACAO",
            "target": "Tables.DtCessacao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-VLR-TOTAL-RECIBO       PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-TOTAL-RECIBO",
            "target": "Tables.VlrTotalRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-DT-IND-APOL-AGREGADA   PIC X(01).",
            "sourceField": "DT-IND-APOL-AGREGADA",
            "target": "Tables.DtIndApolAgregada",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "09  :PREFIX:-EXT5-VLR-TOTAL         PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "EXT5-VLR-TOTAL",
            "target": "Tables.Ext5VlrTotal",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-CAPITAL-RECIBO PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-CAPITAL-RECIBO",
            "target": "Tables.DtVlrCapitalRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-PREMIO-RISCO   PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-PREMIO-RISCO",
            "target": "Tables.DtVlrPremioRisco",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-BONIFICACAO    PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-BONIFICACAO",
            "target": "Tables.DtVlrBonificacao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-TOTAL-RECIBO   PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-TOTAL-RECIBO",
            "target": "Tables.DtVlrTotalRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-FRACC          PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-FRACC",
            "target": "Tables.DtVlrFracc",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-FAT            PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-FAT",
            "target": "Tables.DtVlrFat",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-FGA            PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-FGA",
            "target": "Tables.DtVlrFga",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-SNB            PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-SNB",
            "target": "Tables.DtVlrSnb",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-INEM           PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-INEM",
            "target": "Tables.DtVlrInem",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REGISTO",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0010.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0010Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REGISTO             PIC X(01).",
            "sourceField": "TIPO-REGISTO",
            "target": "PrintRecordControl.TipoRegisto",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0015",
    "originSystem": "FGS",
    "title": "FGS BGOW0015 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FGS.BGOW0015Contract",
    "description": "BGOW0015 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-COMPANHIA / COD-MARCA / COD-ORIGEM / NR-MEDIADOR",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "BGOW0015-COD-COMPANHIA",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-COD-MARCA",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-COD-ORIGEM",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NR-MEDIADOR",
            "sourceField": "NR-MEDIADOR",
            "target": "DocumentInformation.NrMediador",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NR-CLIENTE",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NR-APOLICE",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-COD-PRODUTO",
            "sourceField": "COD-PRODUTO",
            "target": "DocumentInformation.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-DATA-HORA",
            "sourceField": "DATA-HORA",
            "target": "DocumentInformation.DataHora",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NUM-DOC",
            "sourceField": "NUM-DOC",
            "target": "DocumentInformation.NumDoc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NUM-REGISTO",
            "sourceField": "NUM-REGISTO",
            "target": "DocumentInformation.NumRegisto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-TIPO-DOCUMENTO",
            "sourceField": "TIPO-DOCUMENTO",
            "target": "DocumentInformation.TipoDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-TIPO-IMPRESSAO",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-COD-DOCUMENTO-ORIGEM",
            "sourceField": "COD-DOCUMENTO-ORIGEM",
            "target": "DocumentInformation.CodDocumentoOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MARCA-REIMPRESSAO",
            "sourceField": "MARCA-REIMPRESSAO",
            "target": "DocumentInformation.MarcaReimpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-DOC-ID",
            "sourceField": "DOC-ID",
            "target": "DocumentInformation.DocId",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-USER-ID",
            "sourceField": "USER-ID",
            "target": "DocumentInformation.UserId",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-PRODUTO / ADERENTE / APOLICE-NCR",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.Policy",
            "status": "container"
          },
          {
            "source": "BGOW0015-NR-APOLICE",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-COD-PRODUTO",
            "sourceField": "COD-PRODUTO",
            "target": "Policy.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-ADERENTE",
            "sourceField": "ADERENTE",
            "target": "Policy.Aderente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-APOLICE-NCR",
            "sourceField": "APOLICE-NCR",
            "target": "Policy.ApoliceNcr",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NCERTIFICADO",
            "sourceField": "NCERTIFICADO",
            "target": "Policy.Ncertificado",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-RAMO-DSC",
            "sourceField": "RAMO-DSC",
            "target": "Policy.RamoDsc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MODALIDADE",
            "sourceField": "MODALIDADE",
            "target": "Policy.Modalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-PRODUTO",
            "sourceField": "PRODUTO",
            "target": "Policy.Produto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-DADOS-APOLICE",
            "sourceField": "DADOS-APOLICE",
            "target": "Policy.DadosApolice",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "COD-POSTALC / NR-CLIENTE / DADOS-CLIENTE 1 / CL1-NOME",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.Client",
            "status": "container"
          },
          {
            "source": "BGOW0015-COD-POSTALC",
            "sourceField": "COD-POSTALC",
            "target": "Client.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NR-CLIENTE",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-DADOS-CLIENTE 1",
            "sourceField": "DADOS-CLIENTE 1",
            "target": "Client.DadosCliente 1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL1-NOME",
            "sourceField": "CL1-NOME",
            "target": "Client.Cl1Nome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL1-MORADA1",
            "sourceField": "CL1-MORADA1",
            "target": "Client.Cl1Morada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL1-MORADA2",
            "sourceField": "CL1-MORADA2",
            "target": "Client.Cl1Morada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL1-LOCALIDADE",
            "sourceField": "CL1-LOCALIDADE",
            "target": "Client.Cl1Localidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL1-CPOSTAL-DESC",
            "sourceField": "CL1-CPOSTAL-DESC",
            "target": "Client.Cl1CpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL1-TNUM-PORTA",
            "sourceField": "CL1-TNUM-PORTA",
            "target": "Client.Cl1TnumPorta",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL1-NUM-PORTA",
            "sourceField": "CL1-NUM-PORTA",
            "target": "Client.Cl1NumPorta",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL1-NIF",
            "sourceField": "CL1-NIF",
            "target": "Client.Cl1Nif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL-BI",
            "sourceField": "CL-BI",
            "target": "Client.ClBi",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL-TELEF",
            "sourceField": "CL-TELEF",
            "target": "Client.ClTelef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL-EMAIL",
            "sourceField": "CL-EMAIL",
            "target": "Client.ClEmail",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL-SEXO",
            "sourceField": "CL-SEXO",
            "target": "Client.ClSexo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL-DT-NASC",
            "sourceField": "CL-DT-NASC",
            "target": "Client.ClDtNasc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-DADOS-CLIENTE 2",
            "sourceField": "DADOS-CLIENTE 2",
            "target": "Client.DadosCliente 2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-CL2-NOME",
            "sourceField": "CL2-NOME",
            "target": "Client.Cl2Nome",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Mediator",
        "sourceGroup": "COD-POSTALM / NR-MEDIADOR / MEDIADOR-NOME / MEDIADOR-MORADA1",
        "targetType": "Entity?",
        "targetPath": "Mediator",
        "decision": "mapped",
        "description": "Optional mediator party identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.Mediator",
            "status": "container"
          },
          {
            "source": "BGOW0015-COD-POSTALM",
            "sourceField": "COD-POSTALM",
            "target": "Mediator.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NR-MEDIADOR",
            "sourceField": "NR-MEDIADOR",
            "target": "Mediator.NrMediador",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MEDIADOR-NOME",
            "sourceField": "MEDIADOR-NOME",
            "target": "Mediator.MediadorNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MEDIADOR-MORADA1",
            "sourceField": "MEDIADOR-MORADA1",
            "target": "Mediator.MediadorMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MEDIADOR-MORADA2",
            "sourceField": "MEDIADOR-MORADA2",
            "target": "Mediator.MediadorMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MEDIADOR-MORADA3",
            "sourceField": "MEDIADOR-MORADA3",
            "target": "Mediator.MediadorMorada3",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MEDIADOR-MORADA4",
            "sourceField": "MEDIADOR-MORADA4",
            "target": "Mediator.MediadorMorada4",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NOME-MEDIADOR-ANTIGO",
            "sourceField": "NOME-MEDIADOR-ANTIGO",
            "target": "Mediator.NomeMediadorAntigo",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "COD-POSTALM / COD-POSTALC / MORADA1 / MORADA2",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "BGOW0015-COD-POSTALM",
            "sourceField": "COD-POSTALM",
            "target": "MailingAddress.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-COD-POSTALC",
            "sourceField": "COD-POSTALC",
            "target": "MailingAddress.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MORADA1",
            "sourceField": "MORADA1",
            "target": "MailingAddress.Morada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MORADA2",
            "sourceField": "MORADA2",
            "target": "MailingAddress.Morada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MORADA3",
            "sourceField": "MORADA3",
            "target": "MailingAddress.Morada3",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MORADA4",
            "sourceField": "MORADA4",
            "target": "MailingAddress.Morada4",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-TNUM-PORTA",
            "sourceField": "TNUM-PORTA",
            "target": "MailingAddress.TnumPorta",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NUM-PORTA",
            "sourceField": "NUM-PORTA",
            "target": "MailingAddress.NumPorta",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MORADA1-A",
            "sourceField": "MORADA1-A",
            "target": "MailingAddress.Morada1A",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MORADA2-A",
            "sourceField": "MORADA2-A",
            "target": "MailingAddress.Morada2A",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MORADA3-A",
            "sourceField": "MORADA3-A",
            "target": "MailingAddress.Morada3A",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MORADA4-A",
            "sourceField": "MORADA4-A",
            "target": "MailingAddress.Morada4A",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-TNUM-PORTA-A",
            "sourceField": "TNUM-PORTA-A",
            "target": "MailingAddress.TnumPortaA",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NUM-PORTA-A",
            "sourceField": "NUM-PORTA-A",
            "target": "MailingAddress.NumPortaA",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MEDIADOR-MORADA1",
            "sourceField": "MEDIADOR-MORADA1",
            "target": "MailingAddress.MediadorMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MEDIADOR-MORADA2",
            "sourceField": "MEDIADOR-MORADA2",
            "target": "MailingAddress.MediadorMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MEDIADOR-MORADA3",
            "sourceField": "MEDIADOR-MORADA3",
            "target": "MailingAddress.MediadorMorada3",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-MEDIADOR-MORADA4",
            "sourceField": "MEDIADOR-MORADA4",
            "target": "MailingAddress.MediadorMorada4",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-TNUM-PORTA",
            "sourceField": "TNUM-PORTA",
            "target": "MailingAddress.TnumPorta",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NUM-PORTA",
            "sourceField": "NUM-PORTA",
            "target": "MailingAddress.NumPorta",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "PaymentAccount",
        "sourceGroup": "NIB / IBAN / BIC",
        "targetType": "BankAccount?",
        "targetPath": "PaymentAccount",
        "decision": "mapped",
        "description": "Bank-account payment details identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.PaymentAccount",
            "status": "container"
          },
          {
            "source": "BGOW0015-NIB",
            "sourceField": "NIB",
            "target": "PaymentAccount.Nib",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-IBAN",
            "sourceField": "IBAN",
            "target": "PaymentAccount.Iban",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-BIC",
            "sourceField": "BIC",
            "target": "PaymentAccount.Bic",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "DADOS-VALOR / VL-CAPITAL / VL-PREMIO",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.Premium",
            "status": "container"
          },
          {
            "source": "BGOW0015-DADOS-VALOR",
            "sourceField": "DADOS-VALOR",
            "target": "Premium.DadosValor",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-VL-CAPITAL",
            "sourceField": "VL-CAPITAL",
            "target": "Premium.VlCapital",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-VL-PREMIO",
            "sourceField": "VL-PREMIO",
            "target": "Premium.VlPremio",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Coverages",
        "sourceGroup": "DESC-COB-M / DESC-COB-IAD / DESC-COB-ITP",
        "targetType": "IReadOnlyList<Coverage>",
        "targetPath": "Coverages",
        "decision": "mapped",
        "description": "Coverage rows identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.Coverages",
            "status": "container"
          },
          {
            "source": "BGOW0015-DESC-COB-M",
            "sourceField": "DESC-COB-M",
            "target": "Coverages.DescCobM",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-DESC-COB-IAD",
            "sourceField": "DESC-COB-IAD",
            "target": "Coverages.DescCobIad",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-DESC-COB-ITP",
            "sourceField": "DESC-COB-ITP",
            "target": "Coverages.DescCobItp",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "TextBlocks",
        "sourceGroup": "ASSUNTO1 / ASSUNTO2 / ASSUNTO3 / TIPO-LINHA",
        "targetType": "IReadOnlyList<TextBlock>",
        "targetPath": "TextBlocks",
        "decision": "candidate",
        "description": "Document text, notes, clauses, or message lines identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.TextBlocks",
            "status": "container"
          },
          {
            "source": "BGOW0015-ASSUNTO1",
            "sourceField": "ASSUNTO1",
            "target": "TextBlocks.Assunto1",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0015."
          },
          {
            "source": "BGOW0015-ASSUNTO2",
            "sourceField": "ASSUNTO2",
            "target": "TextBlocks.Assunto2",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0015."
          },
          {
            "source": "BGOW0015-ASSUNTO3",
            "sourceField": "ASSUNTO3",
            "target": "TextBlocks.Assunto3",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0015."
          },
          {
            "source": "BGOW0015-TIPO-LINHA",
            "sourceField": "TIPO-LINHA",
            "target": "TextBlocks.TipoLinha",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0015."
          },
          {
            "source": "BGOW0015-LINHA-GIS",
            "sourceField": "LINHA-GIS",
            "target": "TextBlocks.LinhaGis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0015."
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-CARTA-EMISSAO / DT-EMISSAO / DT-ANIVERSARIA / DT-SINISTRO",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.Tables",
            "status": "container"
          },
          {
            "source": "BGOW0015-DT-CARTA-EMISSAO",
            "sourceField": "DT-CARTA-EMISSAO",
            "target": "Tables.DtCartaEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0015."
          },
          {
            "source": "BGOW0015-DT-EMISSAO",
            "sourceField": "DT-EMISSAO",
            "target": "Tables.DtEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0015."
          },
          {
            "source": "BGOW0015-DT-ANIVERSARIA",
            "sourceField": "DT-ANIVERSARIA",
            "target": "Tables.DtAniversaria",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0015."
          },
          {
            "source": "BGOW0015-DT-SINISTRO",
            "sourceField": "DT-SINISTRO",
            "target": "Tables.DtSinistro",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0015."
          },
          {
            "source": "BGOW0015-DT-CARTA-EMISSAO",
            "sourceField": "DT-CARTA-EMISSAO",
            "target": "Tables.DtCartaEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0015."
          },
          {
            "source": "BGOW0015-DT-ANUL",
            "sourceField": "DT-ANUL",
            "target": "Tables.DtAnul",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0015."
          },
          {
            "source": "BGOW0015-DT-EFEITO-ANUL",
            "sourceField": "DT-EFEITO-ANUL",
            "target": "Tables.DtEfeitoAnul",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0015."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "NUM-DOC / NUM-REGISTO / TIPO-REG / DOC-ID",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0015.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0015Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "BGOW0015-NUM-DOC",
            "sourceField": "NUM-DOC",
            "target": "PrintRecordControl.NumDoc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-NUM-REGISTO",
            "sourceField": "NUM-REGISTO",
            "target": "PrintRecordControl.NumRegisto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-TIPO-REG",
            "sourceField": "TIPO-REG",
            "target": "PrintRecordControl.TipoReg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0015-DOC-ID",
            "sourceField": "DOC-ID",
            "target": "PrintRecordControl.DocId",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0019",
    "originSystem": "GIS",
    "title": "GIS BGOW0019 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.GIS.BGOW0019Contract",
    "description": "BGOW0019 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-COMPANHIA / COD-MARCA / COD-ORIGEM / NR-MEDIADOR",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0019.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0019Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "BGOW0019-COD-COMPANHIA",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-COD-MARCA",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-COD-ORIGEM",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NR-MEDIADOR",
            "sourceField": "NR-MEDIADOR",
            "target": "DocumentInformation.NrMediador",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NR-CLIENTE",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NR-APOLICE",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-COD-PRODUTO",
            "sourceField": "COD-PRODUTO",
            "target": "DocumentInformation.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-DATA-HORA",
            "sourceField": "DATA-HORA",
            "target": "DocumentInformation.DataHora",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NUM-DOC",
            "sourceField": "NUM-DOC",
            "target": "DocumentInformation.NumDoc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NUM-REGISTO",
            "sourceField": "NUM-REGISTO",
            "target": "DocumentInformation.NumRegisto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-TIPO-DOCUMENTO",
            "sourceField": "TIPO-DOCUMENTO",
            "target": "DocumentInformation.TipoDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-TIPO-IMPRESSAO",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-COD-DOCUMENTO-ORIGEM",
            "sourceField": "COD-DOCUMENTO-ORIGEM",
            "target": "DocumentInformation.CodDocumentoOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-MARCA-REIMPRESSAO",
            "sourceField": "MARCA-REIMPRESSAO",
            "target": "DocumentInformation.MarcaReimpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-DOC-ID",
            "sourceField": "DOC-ID",
            "target": "DocumentInformation.DocId",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-USER-ID",
            "sourceField": "USER-ID",
            "target": "DocumentInformation.UserId",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-PRODUTO / ADERENTE / APOLICE-NCR",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0019.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0019Contract.Policy",
            "status": "container"
          },
          {
            "source": "BGOW0019-NR-APOLICE",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-COD-PRODUTO",
            "sourceField": "COD-PRODUTO",
            "target": "Policy.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-ADERENTE",
            "sourceField": "ADERENTE",
            "target": "Policy.Aderente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-APOLICE-NCR",
            "sourceField": "APOLICE-NCR",
            "target": "Policy.ApoliceNcr",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NCERTIFICADO",
            "sourceField": "NCERTIFICADO",
            "target": "Policy.Ncertificado",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-RAMO-DSC",
            "sourceField": "RAMO-DSC",
            "target": "Policy.RamoDsc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-MODALIDADE",
            "sourceField": "MODALIDADE",
            "target": "Policy.Modalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-PRODUTO",
            "sourceField": "PRODUTO",
            "target": "Policy.Produto",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "COD-POSTALC / NR-CLIENTE",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0019.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0019Contract.Client",
            "status": "container"
          },
          {
            "source": "BGOW0019-COD-POSTALC",
            "sourceField": "COD-POSTALC",
            "target": "Client.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NR-CLIENTE",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Mediator",
        "sourceGroup": "COD-POSTALM / NR-MEDIADOR / NOME-MEDIADOR / NOME-MEDIADOR-ANTIGO",
        "targetType": "Entity?",
        "targetPath": "Mediator",
        "decision": "mapped",
        "description": "Optional mediator party identified in BGOW0019.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0019Contract.Mediator",
            "status": "container"
          },
          {
            "source": "BGOW0019-COD-POSTALM",
            "sourceField": "COD-POSTALM",
            "target": "Mediator.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NR-MEDIADOR",
            "sourceField": "NR-MEDIADOR",
            "target": "Mediator.NrMediador",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NOME-MEDIADOR",
            "sourceField": "NOME-MEDIADOR",
            "target": "Mediator.NomeMediador",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NOME-MEDIADOR-ANTIGO",
            "sourceField": "NOME-MEDIADOR-ANTIGO",
            "target": "Mediator.NomeMediadorAntigo",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "COD-POSTALM / COD-POSTALC / MORADA1 / MORADA2",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0019.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0019Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "BGOW0019-COD-POSTALM",
            "sourceField": "COD-POSTALM",
            "target": "MailingAddress.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-COD-POSTALC",
            "sourceField": "COD-POSTALC",
            "target": "MailingAddress.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-MORADA1",
            "sourceField": "MORADA1",
            "target": "MailingAddress.Morada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-MORADA2",
            "sourceField": "MORADA2",
            "target": "MailingAddress.Morada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-MORADA3",
            "sourceField": "MORADA3",
            "target": "MailingAddress.Morada3",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-MORADA4",
            "sourceField": "MORADA4",
            "target": "MailingAddress.Morada4",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-TNUM-PORTA",
            "sourceField": "TNUM-PORTA",
            "target": "MailingAddress.TnumPorta",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NUM-PORTA",
            "sourceField": "NUM-PORTA",
            "target": "MailingAddress.NumPorta",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-MORADA1",
            "sourceField": "MORADA1",
            "target": "MailingAddress.Morada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-MORADA2",
            "sourceField": "MORADA2",
            "target": "MailingAddress.Morada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-MORADA3",
            "sourceField": "MORADA3",
            "target": "MailingAddress.Morada3",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-MORADA4",
            "sourceField": "MORADA4",
            "target": "MailingAddress.Morada4",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-TNUM-PORTA",
            "sourceField": "TNUM-PORTA",
            "target": "MailingAddress.TnumPorta",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NUM-PORTA",
            "sourceField": "NUM-PORTA",
            "target": "MailingAddress.NumPorta",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "TextBlocks",
        "sourceGroup": "ASSUNTO1 / ASSUNTO2 / ASSUNTO3 / TIPO-LINHA",
        "targetType": "IReadOnlyList<TextBlock>",
        "targetPath": "TextBlocks",
        "decision": "candidate",
        "description": "Document text, notes, clauses, or message lines identified in BGOW0019.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0019Contract.TextBlocks",
            "status": "container"
          },
          {
            "source": "BGOW0019-ASSUNTO1",
            "sourceField": "ASSUNTO1",
            "target": "TextBlocks.Assunto1",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0019."
          },
          {
            "source": "BGOW0019-ASSUNTO2",
            "sourceField": "ASSUNTO2",
            "target": "TextBlocks.Assunto2",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0019."
          },
          {
            "source": "BGOW0019-ASSUNTO3",
            "sourceField": "ASSUNTO3",
            "target": "TextBlocks.Assunto3",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0019."
          },
          {
            "source": "BGOW0019-TIPO-LINHA",
            "sourceField": "TIPO-LINHA",
            "target": "TextBlocks.TipoLinha",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0019."
          },
          {
            "source": "BGOW0019-LINHA-GIS",
            "sourceField": "LINHA-GIS",
            "target": "TextBlocks.LinhaGis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0019."
          },
          {
            "source": "BGOW0019-LINHA1-GIS",
            "sourceField": "LINHA1-GIS",
            "target": "TextBlocks.Linha1Gis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0019."
          },
          {
            "source": "BGOW0019-LINHA2-GIS",
            "sourceField": "LINHA2-GIS",
            "target": "TextBlocks.Linha2Gis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0019."
          },
          {
            "source": "BGOW0019-LINHA3-GIS",
            "sourceField": "LINHA3-GIS",
            "target": "TextBlocks.Linha3Gis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0019."
          },
          {
            "source": "BGOW0019-LINHA4-GIS",
            "sourceField": "LINHA4-GIS",
            "target": "TextBlocks.Linha4Gis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0019."
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-CARTA-EMISSAO / DT-EMISSAO / DT-ANIVERSARIA / DT-SINISTRO",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0019.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0019Contract.Tables",
            "status": "container"
          },
          {
            "source": "BGOW0019-DT-CARTA-EMISSAO",
            "sourceField": "DT-CARTA-EMISSAO",
            "target": "Tables.DtCartaEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0019."
          },
          {
            "source": "BGOW0019-DT-EMISSAO",
            "sourceField": "DT-EMISSAO",
            "target": "Tables.DtEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0019."
          },
          {
            "source": "BGOW0019-DT-ANIVERSARIA",
            "sourceField": "DT-ANIVERSARIA",
            "target": "Tables.DtAniversaria",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0019."
          },
          {
            "source": "BGOW0019-DT-SINISTRO",
            "sourceField": "DT-SINISTRO",
            "target": "Tables.DtSinistro",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0019."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "NUM-DOC / NUM-REGISTO / TIPO-REG / DOC-ID",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0019.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0019Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "BGOW0019-NUM-DOC",
            "sourceField": "NUM-DOC",
            "target": "PrintRecordControl.NumDoc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-NUM-REGISTO",
            "sourceField": "NUM-REGISTO",
            "target": "PrintRecordControl.NumRegisto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-TIPO-REG",
            "sourceField": "TIPO-REG",
            "target": "PrintRecordControl.TipoReg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0019-DOC-ID",
            "sourceField": "DOC-ID",
            "target": "PrintRecordControl.DocId",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0044",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0044 cancellation letter structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.FS000CancelationLetter",
    "description": "BGOW0044 is represented by the final FS000 cancellation-letter contract. The workbook sheet available in merged_copybooks.xlsx is a relation sheet, so the structure decision is based on the cancellation copybook analysis already migrated into FS000CancelationLetter.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document identification values",
        "targetType": "FS000CancelationLetter",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Each cancellation document id selects a concrete FSCD template while sharing the same final cancellation-letter contract.",
        "rows": [
          {
            "source": null,
            "sourceField": "1037",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1037."
          },
          {
            "source": null,
            "sourceField": "1038",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1038."
          },
          {
            "source": null,
            "sourceField": "1039",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1039."
          },
          {
            "source": null,
            "sourceField": "1040",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1040."
          },
          {
            "source": null,
            "sourceField": "1041",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1041."
          },
          {
            "source": null,
            "sourceField": "1042",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1042."
          },
          {
            "source": null,
            "sourceField": "1043",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1043."
          },
          {
            "source": null,
            "sourceField": "1044",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1044."
          },
          {
            "source": null,
            "sourceField": "1045",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1045."
          },
          {
            "source": null,
            "sourceField": "1046",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1046."
          },
          {
            "source": null,
            "sourceField": "1047",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1047."
          },
          {
            "source": null,
            "sourceField": "1176",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1176."
          },
          {
            "source": null,
            "sourceField": "1177",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1177."
          },
          {
            "source": null,
            "sourceField": "1178",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1178."
          },
          {
            "source": null,
            "sourceField": "1179",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1179."
          },
          {
            "source": null,
            "sourceField": "1180",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1180."
          },
          {
            "source": null,
            "sourceField": "1181",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1181."
          },
          {
            "source": null,
            "sourceField": "1182",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1182."
          },
          {
            "source": null,
            "sourceField": "1183",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1183."
          },
          {
            "source": null,
            "sourceField": "1184",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1184."
          },
          {
            "source": null,
            "sourceField": "1185",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1185."
          }
        ]
      },
      {
        "title": "Cancellation document envelope",
        "sourceGroup": "DADOS-REGISTO / DADOS-CARTA-CANC",
        "targetType": "FS000CancelationLetter",
        "targetPath": "Document and policy metadata",
        "decision": "mapped",
        "description": "The registration header, document code, print data, product reference, issue type, dates, and cancellation reason are kept as explicit cancellation-letter fields because this is the final domain contract for all BGOW0044 cancellation variants.",
        "rows": [
          {
            "source": "05 :PREFIX:-DADOS-REGISTO.",
            "target": "DocumentCode / RecordType / PrintType / OnlinePrintUserId / Policy",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-DADOS-CARTA-CANC.",
            "target": "DocumentNumber / IssueTypeCode / Product / CancelationReasonCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-DADOS-DATA.",
            "target": "PolicyStartDate / PolicyEndDate / IssueDate / CancelationDate / ClaimDate",
            "status": "mapped"
          }
        ]
      },
      {
        "title": "Reusable parties, payment, and risk structures",
        "sourceGroup": "DADOS-CLIENTE / DADOS-AGENTE / DADOS-CREDORHIP / PAGAMENTO / OBJSEGURO",
        "targetType": "FS000CancelationLetter",
        "targetPath": "Client / Agent / MortgageCreditor / BankAccount / AtmPaymentReference / RiskUnit",
        "decision": "mapped",
        "description": "Party, payment, mortgage-creditor, and risk-unit groups were matched to existing common domain objects and composed by FS000CancelationLetter.",
        "rows": [
          {
            "source": "07 :PREFIX:-DADOS-CLIENTE.",
            "target": "Client : Entity",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-DADOS-AGENTE.",
            "target": "Agent : Entity?",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-DADOS-CREDORHIP.",
            "target": "MortgageCreditor : Entity?",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-PG-CONTA / PG-ATM / PG-DEBITO.",
            "target": "PaymentAccount / AtmPayment / DebitAccount",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-DADOS-OBJSEGURO / DADOS-UR.",
            "target": "RiskUnit : RiskUnit?",
            "status": "mapped"
          }
        ]
      },
      {
        "title": "Receipt list records",
        "sourceGroup": "DETALHE-LISTA / FOOTER-LISTA",
        "targetType": "FS000CancelationLetter",
        "targetPath": "ReceiptDetails / ReceiptFooter",
        "decision": "candidate",
        "description": "Receipt detail and footer rows are document list/table records. They remain explicit on FS000 until enough copybooks confirm the final reusable table shape.",
        "rows": [
          {
            "source": "07 :PREFIX:-DETALHE-LISTA.",
            "target": "ReceiptDetails",
            "status": "candidate"
          },
          {
            "source": "07 :PREFIX:-FOOTER-LISTA.",
            "target": "ReceiptFooter",
            "status": "candidate"
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0045",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0045 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.BGOW0045Contract",
    "description": "BGOW0045 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0045Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0045 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1130",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1130."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-DOCUMENTO / TIPO-IMPRESSAO / USERID / COD-COMPANHIA",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0045.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0045Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-DOCUMENTO            PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentInformation.CodDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USERID                   PIC X(08).",
            "sourceField": "USERID",
            "target": "DocumentInformation.Userid",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-AUX-MARCA                PIC X(01).",
            "sourceField": "AUX-MARCA",
            "target": "DocumentInformation.AuxMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "DocumentInformation.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-IND-FLYER                PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "DocumentInformation.IndFlyer",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TIPO-DOCUMENTO         PIC X(01).",
            "sourceField": "TIPO-DOCUMENTO",
            "target": "DocumentInformation.TipoDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-PRODUTO            PIC X(10).",
            "sourceField": "COD-PRODUTO",
            "target": "DocumentInformation.CodProduto",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / TIPO-APOLICE / COD-MOEDA / COD-PRODUTO",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0045.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0045Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TIPO-APOLICE           PIC X(01).",
            "sourceField": "TIPO-APOLICE",
            "target": "Policy.TipoApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-MOEDA              PIC X(03).",
            "sourceField": "COD-MOEDA",
            "target": "Policy.CodMoeda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-PRODUTO            PIC X(10).",
            "sourceField": "COD-PRODUTO",
            "target": "Policy.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-RAMO               PIC X(10).",
            "sourceField": "COD-RAMO",
            "target": "Policy.CodRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DESCR-RAMO-PROD        PIC X(40).",
            "sourceField": "DESCR-RAMO-PROD",
            "target": "Policy.DescrRamoProd",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "NR-CLIENTE / CL-NOME / CL-LOCATION-REF / CL-MORADA1",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0045.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0045Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NOME                PIC X(40).",
            "sourceField": "CL-NOME",
            "target": "Client.ClNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "Client.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "Client.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "Client.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "Client.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "Client.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "Client.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS               PIC X(03).",
            "sourceField": "CL-CPAIS",
            "target": "Client.ClCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS-DESC          PIC X(40).",
            "sourceField": "CL-CPAIS-DESC",
            "target": "Client.ClCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-IDP                 PIC X(04).",
            "sourceField": "CL-IDP",
            "target": "Client.ClIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NIF                 PIC X(22).",
            "sourceField": "CL-NIF",
            "target": "Client.ClNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-TIPO-ENTIDADE       PIC X(01).",
            "sourceField": "CL-TIPO-ENTIDADE",
            "target": "Client.ClTipoEntidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "NR-AGENTE / AG-NOME / AG-LOCATION-REF / AG-MORADA1",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW0045.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0045Contract.Agent",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "Agent.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-NOME                PIC X(40).",
            "sourceField": "AG-NOME",
            "target": "Agent.AgNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-LOCATION-REF        PIC X(04).",
            "sourceField": "AG-LOCATION-REF",
            "target": "Agent.AgLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-MORADA1             PIC X(40).",
            "sourceField": "AG-MORADA1",
            "target": "Agent.AgMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-MORADA2             PIC X(40).",
            "sourceField": "AG-MORADA2",
            "target": "Agent.AgMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-LOCALIDADE          PIC X(40).",
            "sourceField": "AG-LOCALIDADE",
            "target": "Agent.AgLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPOSTAL             PIC X(09).",
            "sourceField": "AG-CPOSTAL",
            "target": "Agent.AgCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "AG-CPOSTAL-DESC",
            "target": "Agent.AgCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPAIS               PIC X(03).",
            "sourceField": "AG-CPAIS",
            "target": "Agent.AgCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPAIS-DESC          PIC X(40).",
            "sourceField": "AG-CPAIS-DESC",
            "target": "Agent.AgCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-IDP                 PIC X(04).",
            "sourceField": "AG-IDP",
            "target": "Agent.AgIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-TELEFONE            PIC X(16).",
            "sourceField": "AG-TELEFONE",
            "target": "Agent.AgTelefone",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-TELEMOVEL           PIC X(16).",
            "sourceField": "AG-TELEMOVEL",
            "target": "Agent.AgTelemovel",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-EMAIL               PIC X(60).",
            "sourceField": "AG-EMAIL",
            "target": "Agent.AgEmail",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-NR-CNT-VENDA        PIC X(10).",
            "sourceField": "AG-NR-CNT-VENDA",
            "target": "Agent.AgNrCntVenda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-VLR-CNT-VENDA       PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "AG-VLR-CNT-VENDA",
            "target": "Agent.AgVlrCntVenda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-NR-CNT-COBRA        PIC X(10).",
            "sourceField": "AG-NR-CNT-COBRA",
            "target": "Agent.AgNrCntCobra",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-VLR-CNT-COBRA       PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "AG-VLR-CNT-COBRA",
            "target": "Agent.AgVlrCntCobra",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "CL-LOCATION-REF / CL-MORADA1 / CL-MORADA2 / CL-LOCALIDADE",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0045.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0045Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "MailingAddress.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "MailingAddress.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "MailingAddress.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "MailingAddress.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "MailingAddress.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "MailingAddress.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-LOCATION-REF        PIC X(04).",
            "sourceField": "AG-LOCATION-REF",
            "target": "MailingAddress.AgLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-MORADA1             PIC X(40).",
            "sourceField": "AG-MORADA1",
            "target": "MailingAddress.AgMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-MORADA2             PIC X(40).",
            "sourceField": "AG-MORADA2",
            "target": "MailingAddress.AgMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-LOCALIDADE          PIC X(40).",
            "sourceField": "AG-LOCALIDADE",
            "target": "MailingAddress.AgLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPOSTAL             PIC X(09).",
            "sourceField": "AG-CPOSTAL",
            "target": "MailingAddress.AgCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "AG-CPOSTAL-DESC",
            "target": "MailingAddress.AgCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "VLR-TOTAL-RECIBO / AG-VLR-CNT-VENDA / AG-VLR-CNT-COBRA / AG-VLR-CNT-ESPEC",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0045.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0045Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-VLR-TOTAL-RECIBO       PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "VLR-TOTAL-RECIBO",
            "target": "Premium.VlrTotalRecibo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-VLR-CNT-VENDA       PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "AG-VLR-CNT-VENDA",
            "target": "Premium.AgVlrCntVenda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-VLR-CNT-COBRA       PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "AG-VLR-CNT-COBRA",
            "target": "Premium.AgVlrCntCobra",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-VLR-CNT-ESPEC       PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "AG-VLR-CNT-ESPEC",
            "target": "Premium.AgVlrCntEspec",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-VLR-CNT-PARCE       PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "AG-VLR-CNT-PARCE",
            "target": "Premium.AgVlrCntParce",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-FRT-VLR-ANUAL          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "FRT-VLR-ANUAL",
            "target": "Premium.FrtVlrAnual",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-FRT-VLR-RISCO          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "FRT-VLR-RISCO",
            "target": "Premium.FrtVlrRisco",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "RiskUnit",
        "sourceGroup": "FRT-DT-INI-RISCO / FRT-DT-FIM-RISCO / FRT-VLR-RISCO / FTR-TOT-RISCO",
        "targetType": "RiskUnit",
        "targetPath": "RiskUnit",
        "decision": "mapped",
        "description": "Insured object, insured person, or risk-unit data identified in BGOW0045.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0045Contract.RiskUnit",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-FRT-DT-INI-RISCO       PIC X(08).",
            "sourceField": "FRT-DT-INI-RISCO",
            "target": "RiskUnit.FrtDtIniRisco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-FRT-DT-FIM-RISCO       PIC X(08).",
            "sourceField": "FRT-DT-FIM-RISCO",
            "target": "RiskUnit.FrtDtFimRisco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-FRT-VLR-RISCO          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "FRT-VLR-RISCO",
            "target": "RiskUnit.FrtVlrRisco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-FTR-TOT-RISCO          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "FTR-TOT-RISCO",
            "target": "RiskUnit.FtrTotRisco",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-INI-APOL / DT-FIM-APOL / DT-INI-REC / DT-FIM-REC",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0045Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-INI-APOL            PIC X(08).",
            "sourceField": "DT-INI-APOL",
            "target": "Tables.DtIniApol",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-DT-FIM-APOL            PIC X(08).",
            "sourceField": "DT-FIM-APOL",
            "target": "Tables.DtFimApol",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-DT-INI-REC             PIC X(08).",
            "sourceField": "DT-INI-REC",
            "target": "Tables.DtIniRec",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-DT-FIM-REC             PIC X(08).",
            "sourceField": "DT-FIM-REC",
            "target": "Tables.DtFimRec",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-DT-EXTRACAO            PIC X(08).",
            "sourceField": "DT-EXTRACAO",
            "target": "Tables.DtExtracao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-DT-EMISSAO             PIC X(08).",
            "sourceField": "DT-EMISSAO",
            "target": "Tables.DtEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-VLR-TOTAL-RECIBO       PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "VLR-TOTAL-RECIBO",
            "target": "Tables.VlrTotalRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-FRT-TIPO-TRANSAC       PIC X(02).",
            "sourceField": "FRT-TIPO-TRANSAC",
            "target": "Tables.FrtTipoTransac",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-FRT-OBSERVACAO         PIC X(15).",
            "sourceField": "FRT-OBSERVACAO",
            "target": "Tables.FrtObservacao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-FRT-DT-PROCESSO        PIC X(08).",
            "sourceField": "FRT-DT-PROCESSO",
            "target": "Tables.FrtDtProcesso",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-FRT-DT-APROVACAO       PIC X(08).",
            "sourceField": "FRT-DT-APROVACAO",
            "target": "Tables.FrtDtAprovacao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-FRT-DT-INI-RISCO       PIC X(08).",
            "sourceField": "FRT-DT-INI-RISCO",
            "target": "Tables.FrtDtIniRisco",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-FRT-DT-FIM-RISCO       PIC X(08).",
            "sourceField": "FRT-DT-FIM-RISCO",
            "target": "Tables.FrtDtFimRisco",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-FRT-VLR-ANUAL          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "FRT-VLR-ANUAL",
            "target": "Tables.FrtVlrAnual",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          },
          {
            "source": "09  :PREFIX:-FRT-VLR-RISCO          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "FRT-VLR-RISCO",
            "target": "Tables.FrtVlrRisco",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REGISTO",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0045.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0045Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REGISTO             PIC X(01).",
            "sourceField": "TIPO-REGISTO",
            "target": "PrintRecordControl.TipoRegisto",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0046",
    "originSystem": "GIS",
    "title": "GIS BGOW0046 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.GIS.BGOW0046Contract",
    "description": "BGOW0046 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0046Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0046 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1244",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1244."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-COMPANHIA / COD-MARCA / COD-ORIGEM / NR-MEDIADOR",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0046.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0046Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "BGOW0046-COD-COMPANHIA",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-COD-MARCA",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-COD-ORIGEM",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-NR-MEDIADOR",
            "sourceField": "NR-MEDIADOR",
            "target": "DocumentInformation.NrMediador",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-NR-CLIENTE",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-NR-APOLICE",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-COD-PRODUTO",
            "sourceField": "COD-PRODUTO",
            "target": "DocumentInformation.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-DATA-HORA",
            "sourceField": "DATA-HORA",
            "target": "DocumentInformation.DataHora",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-NUM-DOC",
            "sourceField": "NUM-DOC",
            "target": "DocumentInformation.NumDoc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-NUM-REGISTO",
            "sourceField": "NUM-REGISTO",
            "target": "DocumentInformation.NumRegisto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-TIPO-DOCUMENTO",
            "sourceField": "TIPO-DOCUMENTO",
            "target": "DocumentInformation.TipoDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-TIPO-IMPRESSAO",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-COD-DOCUMENTO-ORIGEM",
            "sourceField": "COD-DOCUMENTO-ORIGEM",
            "target": "DocumentInformation.CodDocumentoOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-MARCA-REIMPRESSAO",
            "sourceField": "MARCA-REIMPRESSAO",
            "target": "DocumentInformation.MarcaReimpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-DOC-ID",
            "sourceField": "DOC-ID",
            "target": "DocumentInformation.DocId",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-USER-ID",
            "sourceField": "USER-ID",
            "target": "DocumentInformation.UserId",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-PRODUTO / ADERENTE / APOLICE-NCR",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0046.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0046Contract.Policy",
            "status": "container"
          },
          {
            "source": "BGOW0046-NR-APOLICE",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-COD-PRODUTO",
            "sourceField": "COD-PRODUTO",
            "target": "Policy.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-ADERENTE",
            "sourceField": "ADERENTE",
            "target": "Policy.Aderente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-APOLICE-NCR",
            "sourceField": "APOLICE-NCR",
            "target": "Policy.ApoliceNcr",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-Q1-PRODUTO",
            "sourceField": "Q1-PRODUTO",
            "target": "Policy.Q1Produto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-Q2- PRODUTO",
            "sourceField": "Q2- PRODUTO",
            "target": "Policy.Q2 Produto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-Q3-PRODUTO",
            "sourceField": "Q3-PRODUTO",
            "target": "Policy.Q3Produto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-Q4-PRODUTO",
            "sourceField": "Q4-PRODUTO",
            "target": "Policy.Q4Produto",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "COD-POSTALC / NR-CLIENTE",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0046.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0046Contract.Client",
            "status": "container"
          },
          {
            "source": "BGOW0046-COD-POSTALC",
            "sourceField": "COD-POSTALC",
            "target": "Client.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-NR-CLIENTE",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Mediator",
        "sourceGroup": "COD-POSTALM / NR-MEDIADOR",
        "targetType": "Entity?",
        "targetPath": "Mediator",
        "decision": "mapped",
        "description": "Optional mediator party identified in BGOW0046.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0046Contract.Mediator",
            "status": "container"
          },
          {
            "source": "BGOW0046-COD-POSTALM",
            "sourceField": "COD-POSTALM",
            "target": "Mediator.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-NR-MEDIADOR",
            "sourceField": "NR-MEDIADOR",
            "target": "Mediator.NrMediador",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "COD-POSTALM / COD-POSTALC / MORADA1 / MORADA2",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0046.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0046Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "BGOW0046-COD-POSTALM",
            "sourceField": "COD-POSTALM",
            "target": "MailingAddress.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-COD-POSTALC",
            "sourceField": "COD-POSTALC",
            "target": "MailingAddress.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-MORADA1",
            "sourceField": "MORADA1",
            "target": "MailingAddress.Morada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-MORADA2",
            "sourceField": "MORADA2",
            "target": "MailingAddress.Morada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-MORADA3",
            "sourceField": "MORADA3",
            "target": "MailingAddress.Morada3",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-MORADA4",
            "sourceField": "MORADA4",
            "target": "MailingAddress.Morada4",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-REF-MORADA",
            "sourceField": "REF-MORADA",
            "target": "MailingAddress.RefMorada",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "SI-SALDO / Q1-SALDO-AP / Q1-SALDO-OI / Q2-VALOR-BRUTO",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0046.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0046Contract.Premium",
            "status": "container"
          },
          {
            "source": "BGOW0046-SI-SALDO",
            "sourceField": "SI-SALDO",
            "target": "Premium.SiSaldo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-Q1-SALDO-AP",
            "sourceField": "Q1-SALDO-AP",
            "target": "Premium.Q1SaldoAp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-Q1-SALDO-OI",
            "sourceField": "Q1-SALDO-OI",
            "target": "Premium.Q1SaldoOi",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-Q2-VALOR-BRUTO",
            "sourceField": "Q2-VALOR-BRUTO",
            "target": "Premium.Q2ValorBruto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-Q2-VALOR-LIQ",
            "sourceField": "Q2-VALOR-LIQ",
            "target": "Premium.Q2ValorLiq",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "TextBlocks",
        "sourceGroup": "TIPO-LINHA / LINHA-GIS / LINHA1-GIS / LINHA2-GIS",
        "targetType": "IReadOnlyList<TextBlock>",
        "targetPath": "TextBlocks",
        "decision": "candidate",
        "description": "Document text, notes, clauses, or message lines identified in BGOW0046.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0046Contract.TextBlocks",
            "status": "container"
          },
          {
            "source": "BGOW0046-TIPO-LINHA",
            "sourceField": "TIPO-LINHA",
            "target": "TextBlocks.TipoLinha",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0046."
          },
          {
            "source": "BGOW0046-LINHA-GIS",
            "sourceField": "LINHA-GIS",
            "target": "TextBlocks.LinhaGis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0046."
          },
          {
            "source": "BGOW0046-LINHA1-GIS",
            "sourceField": "LINHA1-GIS",
            "target": "TextBlocks.Linha1Gis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0046."
          },
          {
            "source": "BGOW0046-LINHA2-GIS",
            "sourceField": "LINHA2-GIS",
            "target": "TextBlocks.Linha2Gis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0046."
          },
          {
            "source": "BGOW0046-LINHA3-GIS",
            "sourceField": "LINHA3-GIS",
            "target": "TextBlocks.Linha3Gis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0046."
          },
          {
            "source": "BGOW0046-LINHA4-GIS",
            "sourceField": "LINHA4-GIS",
            "target": "TextBlocks.Linha4Gis",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q4-DESCRITIVO",
            "sourceField": "Q4-DESCRITIVO",
            "target": "TextBlocks.Q4Descritivo",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0046."
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-EMISSAO / DT-INF / SI-DT-POSICAO / SI-SALDO",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0046Contract.Tables",
            "status": "container"
          },
          {
            "source": "BGOW0046-DT-EMISSAO",
            "sourceField": "DT-EMISSAO",
            "target": "Tables.DtEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-DT-INF",
            "sourceField": "DT-INF",
            "target": "Tables.DtInf",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-SI-DT-POSICAO",
            "sourceField": "SI-DT-POSICAO",
            "target": "Tables.SiDtPosicao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-SI-SALDO",
            "sourceField": "SI-SALDO",
            "target": "Tables.SiSaldo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q1-PRODUTO",
            "sourceField": "Q1-PRODUTO",
            "target": "Tables.Q1Produto",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q1-APOL-ADESAO",
            "sourceField": "Q1-APOL-ADESAO",
            "target": "Tables.Q1ApolAdesao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q1-DT-INICIO",
            "sourceField": "Q1-DT-INICIO",
            "target": "Tables.Q1DtInicio",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q1-DT-TERMO",
            "sourceField": "Q1-DT-TERMO",
            "target": "Tables.Q1DtTermo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q1-SALDO-AP",
            "sourceField": "Q1-SALDO-AP",
            "target": "Tables.Q1SaldoAp",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q1-OPCAO-INVEST",
            "sourceField": "Q1-OPCAO-INVEST",
            "target": "Tables.Q1OpcaoInvest",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q1-NUNI-UC-UR",
            "sourceField": "Q1-NUNI-UC-UR",
            "target": "Tables.Q1NuniUcUr",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q1-COTACAO-UC-UR",
            "sourceField": "Q1-COTACAO-UC-UR",
            "target": "Tables.Q1CotacaoUcUr",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q1-SALDO-OI",
            "sourceField": "Q1-SALDO-OI",
            "target": "Tables.Q1SaldoOi",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q2- PRODUTO",
            "sourceField": "Q2- PRODUTO",
            "target": "Tables.Q2 Produto",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q2-APOL-ADESAO",
            "sourceField": "Q2-APOL-ADESAO",
            "target": "Tables.Q2ApolAdesao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q2-DT",
            "sourceField": "Q2-DT",
            "target": "Tables.Q2Dt",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q2-MOVIMENTOS",
            "sourceField": "Q2-MOVIMENTOS",
            "target": "Tables.Q2Movimentos",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          },
          {
            "source": "BGOW0046-Q2-OPCAO-INVEST",
            "sourceField": "Q2-OPCAO-INVEST",
            "target": "Tables.Q2OpcaoInvest",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0046."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "NUM-DOC / NUM-REGISTO / TIPO-REG / DOC-ID",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0046.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0046Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "BGOW0046-NUM-DOC",
            "sourceField": "NUM-DOC",
            "target": "PrintRecordControl.NumDoc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-NUM-REGISTO",
            "sourceField": "NUM-REGISTO",
            "target": "PrintRecordControl.NumRegisto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-TIPO-REG",
            "sourceField": "TIPO-REG",
            "target": "PrintRecordControl.TipoReg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "BGOW0046-DOC-ID",
            "sourceField": "DOC-ID",
            "target": "PrintRecordControl.DocId",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0054",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0054 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.BGOW0054Contract",
    "description": "BGOW0054 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0054Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0054 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1144",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1144."
          },
          {
            "source": null,
            "sourceField": "1145",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1145."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-DOCUMENTO / TIPO-IMPRESSAO / USERID / COD-COMPANHIA",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-DOCUMENTO            PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentInformation.CodDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USERID                   PIC X(08).",
            "sourceField": "USERID",
            "target": "DocumentInformation.Userid",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-AUX-MARCA                PIC X(01).",
            "sourceField": "AUX-MARCA",
            "target": "DocumentInformation.AuxMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "DocumentInformation.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-IND-FLYER                PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "DocumentInformation.IndFlyer",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-NR-APOLICE          PIC X(16).",
            "sourceField": "DT-NR-APOLICE",
            "target": "DocumentInformation.DtNrApolice",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-MOEDA / DT-COD-RAMO / DT-NR-APOLICE",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-MOEDA              PIC X(03).",
            "sourceField": "COD-MOEDA",
            "target": "Policy.CodMoeda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-COD-RAMO            PIC X(10).",
            "sourceField": "DT-COD-RAMO",
            "target": "Policy.DtCodRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-NR-APOLICE          PIC X(16).",
            "sourceField": "DT-NR-APOLICE",
            "target": "Policy.DtNrApolice",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "NR-CLIENTE / CL-NOME / CL-LOCATION-REF / CL-MORADA1",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NOME                PIC X(40).",
            "sourceField": "CL-NOME",
            "target": "Client.ClNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "Client.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "Client.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "Client.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "Client.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "Client.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "Client.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS               PIC X(03).",
            "sourceField": "CL-CPAIS",
            "target": "Client.ClCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS-DESC          PIC X(40).",
            "sourceField": "CL-CPAIS-DESC",
            "target": "Client.ClCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-IDP                 PIC X(04).",
            "sourceField": "CL-IDP",
            "target": "Client.ClIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NIF                 PIC X(22).",
            "sourceField": "CL-NIF",
            "target": "Client.ClNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-TIPO-ENTIDADE       PIC X(01).",
            "sourceField": "CL-TIPO-ENTIDADE",
            "target": "Client.ClTipoEntidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "NR-AGENTE",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.Agent",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "Agent.NrAgente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Creditor",
        "sourceGroup": "CH-NR-CHEQUE / CH-DATA-CHEQUE / CH-LINHA-OTICA / CH-EXTENSO-L1",
        "targetType": "Entity?",
        "targetPath": "Creditor",
        "decision": "mapped",
        "description": "Optional creditor or mortgage creditor party identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.Creditor",
            "status": "container"
          },
          {
            "source": "11  :PREFIX:-CH-NR-CHEQUE       PIC X(10).",
            "sourceField": "CH-NR-CHEQUE",
            "target": "Creditor.ChNrCheque",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CH-DATA-CHEQUE     PIC X(08).",
            "sourceField": "CH-DATA-CHEQUE",
            "target": "Creditor.ChDataCheque",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CH-LINHA-OTICA     PIC X(52).",
            "sourceField": "CH-LINHA-OTICA",
            "target": "Creditor.ChLinhaOtica",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CH-EXTENSO-L1      PIC X(100).",
            "sourceField": "CH-EXTENSO-L1",
            "target": "Creditor.ChExtensoL1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CH-EXTENSO-L2      PIC X(100).",
            "sourceField": "CH-EXTENSO-L2",
            "target": "Creditor.ChExtensoL2",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Lawyer",
        "sourceGroup": "AD-NUMERO / AD-NOME / AD-LOCATION-REF / AD-MORADA1",
        "targetType": "Entity?",
        "targetPath": "Lawyer",
        "decision": "mapped",
        "description": "Optional lawyer party identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.Lawyer",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-AD-NUMERO              PIC X(10).",
            "sourceField": "AD-NUMERO",
            "target": "Lawyer.AdNumero",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-NOME                PIC X(40).",
            "sourceField": "AD-NOME",
            "target": "Lawyer.AdNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-LOCATION-REF        PIC X(04).",
            "sourceField": "AD-LOCATION-REF",
            "target": "Lawyer.AdLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-MORADA1             PIC X(40).",
            "sourceField": "AD-MORADA1",
            "target": "Lawyer.AdMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-MORADA2             PIC X(40).",
            "sourceField": "AD-MORADA2",
            "target": "Lawyer.AdMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-LOCALIDADE          PIC X(40).",
            "sourceField": "AD-LOCALIDADE",
            "target": "Lawyer.AdLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-CPOSTAL             PIC X(09).",
            "sourceField": "AD-CPOSTAL",
            "target": "Lawyer.AdCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "AD-CPOSTAL-DESC",
            "target": "Lawyer.AdCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-CPAIS               PIC X(03).",
            "sourceField": "AD-CPAIS",
            "target": "Lawyer.AdCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-CPAIS-DESC          PIC X(40).",
            "sourceField": "AD-CPAIS-DESC",
            "target": "Lawyer.AdCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-IDP                 PIC X(04).",
            "sourceField": "AD-IDP",
            "target": "Lawyer.AdIdp",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "CL-LOCATION-REF / CL-MORADA1 / CL-MORADA2 / CL-LOCALIDADE",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "MailingAddress.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "MailingAddress.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "MailingAddress.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "MailingAddress.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "MailingAddress.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "MailingAddress.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-LOCATION-REF        PIC X(04).",
            "sourceField": "AD-LOCATION-REF",
            "target": "MailingAddress.AdLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-MORADA1             PIC X(40).",
            "sourceField": "AD-MORADA1",
            "target": "MailingAddress.AdMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-MORADA2             PIC X(40).",
            "sourceField": "AD-MORADA2",
            "target": "MailingAddress.AdMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-LOCALIDADE          PIC X(40).",
            "sourceField": "AD-LOCALIDADE",
            "target": "MailingAddress.AdLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-CPOSTAL             PIC X(09).",
            "sourceField": "AD-CPOSTAL",
            "target": "MailingAddress.AdCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AD-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "AD-CPOSTAL-DESC",
            "target": "MailingAddress.AdCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "PaymentAccount",
        "sourceGroup": "DEB-NOME-BANCO / DEB-IBAN / DEB-SWIFT",
        "targetType": "BankAccount?",
        "targetPath": "PaymentAccount",
        "decision": "mapped",
        "description": "Bank-account payment details identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.PaymentAccount",
            "status": "container"
          },
          {
            "source": "11  :PREFIX:-DEB-NOME-BANCO     PIC X(60).",
            "sourceField": "DEB-NOME-BANCO",
            "target": "PaymentAccount.DebNomeBanco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-DEB-IBAN           PIC X(34).",
            "sourceField": "DEB-IBAN",
            "target": "PaymentAccount.DebIban",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-DEB-SWIFT          PIC X(11).",
            "sourceField": "DEB-SWIFT",
            "target": "PaymentAccount.DebSwift",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "DT-VLR-IRS / DT-VLR-RECIBO / TT-VLR-IRS / TT-VLR-RECIBO",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-VLR-IRS             PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-IRS",
            "target": "Premium.DtVlrIrs",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-VLR-RECIBO          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-RECIBO",
            "target": "Premium.DtVlrRecibo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TT-VLR-IRS             PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "TT-VLR-IRS",
            "target": "Premium.TtVlrIrs",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TT-VLR-RECIBO          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "TT-VLR-RECIBO",
            "target": "Premium.TtVlrRecibo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TT-VLR-RET             PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "TT-VLR-RET",
            "target": "Premium.TtVlrRet",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TT-VLR-TOT             PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "TT-VLR-TOT",
            "target": "Premium.TtVlrTot",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TT-VLR-TOTT       REDEFINES\n        :PREFIX:-TT-VLR-TOT             PIC S9(15).",
            "sourceField": "TT-VLR-TOTT",
            "target": "Premium.TtVlrTott",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "TextBlocks",
        "sourceGroup": "CH-LINHA-OTICA / DT-DESCRITIVO1 / DT-DESCRITIVO2 / DT-DESCRITIVO3",
        "targetType": "IReadOnlyList<TextBlock>",
        "targetPath": "TextBlocks",
        "decision": "candidate",
        "description": "Document text, notes, clauses, or message lines identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.TextBlocks",
            "status": "container"
          },
          {
            "source": "11  :PREFIX:-CH-LINHA-OTICA     PIC X(52).",
            "sourceField": "CH-LINHA-OTICA",
            "target": "TextBlocks.ChLinhaOtica",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0054."
          },
          {
            "source": "11  :PREFIX:-DT-DESCRITIVO1     PIC X(65).",
            "sourceField": "DT-DESCRITIVO1",
            "target": "TextBlocks.DtDescritivo1",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0054."
          },
          {
            "source": "11  :PREFIX:-DT-DESCRITIVO2     PIC X(65).",
            "sourceField": "DT-DESCRITIVO2",
            "target": "TextBlocks.DtDescritivo2",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0054."
          },
          {
            "source": "11  :PREFIX:-DT-DESCRITIVO3     PIC X(65).",
            "sourceField": "DT-DESCRITIVO3",
            "target": "TextBlocks.DtDescritivo3",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0054."
          },
          {
            "source": "11  :PREFIX:-DT-DESCRITIVO4     PIC X(65).",
            "sourceField": "DT-DESCRITIVO4",
            "target": "TextBlocks.DtDescritivo4",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0054."
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-EMISSAO / DT-COD-RAMO / DT-NR-SINISTRO / DT-NR-RECIBO",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-EMISSAO             PIC X(08).",
            "sourceField": "DT-EMISSAO",
            "target": "Tables.DtEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-DT-COD-RAMO            PIC X(10).",
            "sourceField": "DT-COD-RAMO",
            "target": "Tables.DtCodRamo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-DT-NR-SINISTRO         PIC X(12).",
            "sourceField": "DT-NR-SINISTRO",
            "target": "Tables.DtNrSinistro",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-DT-NR-RECIBO           PIC X(16).",
            "sourceField": "DT-NR-RECIBO",
            "target": "Tables.DtNrRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-DT-NR-APOLICE          PIC X(16).",
            "sourceField": "DT-NR-APOLICE",
            "target": "Tables.DtNrApolice",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "11  :PREFIX:-DT-DESCRITIVO1     PIC X(65).",
            "sourceField": "DT-DESCRITIVO1",
            "target": "Tables.DtDescritivo1",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "11  :PREFIX:-DT-DESCRITIVO2     PIC X(65).",
            "sourceField": "DT-DESCRITIVO2",
            "target": "Tables.DtDescritivo2",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "11  :PREFIX:-DT-DESCRITIVO3     PIC X(65).",
            "sourceField": "DT-DESCRITIVO3",
            "target": "Tables.DtDescritivo3",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "11  :PREFIX:-DT-DESCRITIVO4     PIC X(65).",
            "sourceField": "DT-DESCRITIVO4",
            "target": "Tables.DtDescritivo4",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-IRS             PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-IRS",
            "target": "Tables.DtVlrIrs",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-RECIBO          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-RECIBO",
            "target": "Tables.DtVlrRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-TT-VLR-IRS             PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "TT-VLR-IRS",
            "target": "Tables.TtVlrIrs",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-TT-VLR-RECIBO          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "TT-VLR-RECIBO",
            "target": "Tables.TtVlrRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-TT-VLR-RET             PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "TT-VLR-RET",
            "target": "Tables.TtVlrRet",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-TT-VLR-TOT             PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "TT-VLR-TOT",
            "target": "Tables.TtVlrTot",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          },
          {
            "source": "09  :PREFIX:-TT-VLR-TOTT       REDEFINES\n        :PREFIX:-TT-VLR-TOT             PIC S9(15).",
            "sourceField": "TT-VLR-TOTT",
            "target": "Tables.TtVlrTott",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REGISTO",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0054.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0054Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REGISTO             PIC X(01).",
            "sourceField": "TIPO-REGISTO",
            "target": "PrintRecordControl.TipoRegisto",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0055",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0055 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.BGOW0055Contract",
    "description": "BGOW0055 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0055Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0055 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "0481",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 0481."
          },
          {
            "source": null,
            "sourceField": "1142",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1142."
          },
          {
            "source": null,
            "sourceField": "1143",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1143."
          },
          {
            "source": null,
            "sourceField": "1146",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1146."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-DOCUMENTO / TIPO-IMPRESSAO / USERID / COD-COMPANHIA",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0055.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0055Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-DOCUMENTO            PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentInformation.CodDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USERID                   PIC X(08).",
            "sourceField": "USERID",
            "target": "DocumentInformation.Userid",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-AUX-MARCA                PIC X(01).",
            "sourceField": "AUX-MARCA",
            "target": "DocumentInformation.AuxMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "DocumentInformation.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-IND-FLYER                PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "DocumentInformation.IndFlyer",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-NR-APOLICE-SO          PIC X(16).",
            "sourceField": "NR-APOLICE-SO",
            "target": "DocumentInformation.NrApoliceSo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-PRODUTO            PIC X(10).",
            "sourceField": "COD-PRODUTO",
            "target": "DocumentInformation.CodProduto",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / NR-APOLICE-SO / COD-MOEDA / COD-PRODUTO",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0055.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0055Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-NR-APOLICE-SO          PIC X(16).",
            "sourceField": "NR-APOLICE-SO",
            "target": "Policy.NrApoliceSo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-MOEDA              PIC X(03).",
            "sourceField": "COD-MOEDA",
            "target": "Policy.CodMoeda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-PRODUTO            PIC X(10).",
            "sourceField": "COD-PRODUTO",
            "target": "Policy.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-RAMO               PIC X(10).",
            "sourceField": "COD-RAMO",
            "target": "Policy.CodRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DESCR-RAMO-PROD        PIC X(40).",
            "sourceField": "DESCR-RAMO-PROD",
            "target": "Policy.DescrRamoProd",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "NR-CLIENTE / CL-NOME / CL-LOCATION-REF / CL-MORADA1",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0055.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0055Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NOME                PIC X(40).",
            "sourceField": "CL-NOME",
            "target": "Client.ClNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "Client.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "Client.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "Client.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "Client.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "Client.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "Client.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS               PIC X(03).",
            "sourceField": "CL-CPAIS",
            "target": "Client.ClCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS-DESC          PIC X(40).",
            "sourceField": "CL-CPAIS-DESC",
            "target": "Client.ClCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-IDP                 PIC X(04).",
            "sourceField": "CL-IDP",
            "target": "Client.ClIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NIF                 PIC X(22).",
            "sourceField": "CL-NIF",
            "target": "Client.ClNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-TIPO-ENTIDADE       PIC X(01).",
            "sourceField": "CL-TIPO-ENTIDADE",
            "target": "Client.ClTipoEntidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "NR-AGENTE",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW0055.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0055Contract.Agent",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "Agent.NrAgente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "CL-LOCATION-REF / CL-MORADA1 / CL-MORADA2 / CL-LOCALIDADE",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0055.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0055Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "MailingAddress.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "MailingAddress.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "MailingAddress.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "MailingAddress.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "MailingAddress.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "MailingAddress.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "PaymentAccount",
        "sourceGroup": "CNT-NOME-BANCO / CNT-IBAN / CNT-SWIFT / DEB-ADD",
        "targetType": "BankAccount?",
        "targetPath": "PaymentAccount",
        "decision": "mapped",
        "description": "Bank-account payment details identified in BGOW0055.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0055Contract.PaymentAccount",
            "status": "container"
          },
          {
            "source": "11  :PREFIX:-CNT-NOME-BANCO       PIC X(60).",
            "sourceField": "CNT-NOME-BANCO",
            "target": "PaymentAccount.CntNomeBanco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CNT-IBAN             PIC X(34).",
            "sourceField": "CNT-IBAN",
            "target": "PaymentAccount.CntIban",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CNT-SWIFT            PIC X(11).",
            "sourceField": "CNT-SWIFT",
            "target": "PaymentAccount.CntSwift",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-DEB-ADD              PIC X(11).",
            "sourceField": "DEB-ADD",
            "target": "PaymentAccount.DebAdd",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "AtmPayment",
        "sourceGroup": "ATM-ENTIDADE / ATM-REF",
        "targetType": "AtmPaymentReference?",
        "targetPath": "AtmPayment",
        "decision": "mapped",
        "description": "ATM payment entity/reference details identified in BGOW0055.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0055Contract.AtmPayment",
            "status": "container"
          },
          {
            "source": "11  :PREFIX:-ATM-ENTIDADE         PIC X(05).",
            "sourceField": "ATM-ENTIDADE",
            "target": "AtmPayment.AtmEntidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-ATM-REF              PIC X(09).",
            "sourceField": "ATM-REF",
            "target": "AtmPayment.AtmRef",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "VLR-PAGAMENTO",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0055.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0055Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-VLR-PAGAMENTO          PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "VLR-PAGAMENTO",
            "target": "Premium.VlrPagamento",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-CARTA / DT-VENCIMENTO / DT-RESGATE / DT-LIMITE-PAG",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0055.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0055Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-CARTA               PIC X(08).",
            "sourceField": "DT-CARTA",
            "target": "Tables.DtCarta",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0055."
          },
          {
            "source": "09  :PREFIX:-DT-VENCIMENTO          PIC X(08).",
            "sourceField": "DT-VENCIMENTO",
            "target": "Tables.DtVencimento",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0055."
          },
          {
            "source": "09  :PREFIX:-DT-RESGATE             PIC X(08).",
            "sourceField": "DT-RESGATE",
            "target": "Tables.DtResgate",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0055."
          },
          {
            "source": "09  :PREFIX:-DT-LIMITE-PAG          PIC X(08).",
            "sourceField": "DT-LIMITE-PAG",
            "target": "Tables.DtLimitePag",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0055."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REGISTO",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0055.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0055Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REGISTO             PIC X(01).",
            "sourceField": "TIPO-REGISTO",
            "target": "PrintRecordControl.TipoRegisto",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0056",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0056 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.BGOW0056Contract",
    "description": "BGOW0056 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0056Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0056 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1147",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1147."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-DOCUMENTO / TIPO-IMPRESSAO / USERID / COD-COMPANHIA",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0056.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0056Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-DOCUMENTO            PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentInformation.CodDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USERID                   PIC X(08).",
            "sourceField": "USERID",
            "target": "DocumentInformation.Userid",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-AUX-MARCA                PIC X(01).",
            "sourceField": "AUX-MARCA",
            "target": "DocumentInformation.AuxMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "DocumentInformation.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-IND-FLYER                PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "DocumentInformation.IndFlyer",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-MOEDA",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0056.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0056Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-MOEDA              PIC X(03).",
            "sourceField": "COD-MOEDA",
            "target": "Policy.CodMoeda",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "NR-CLIENTE",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0056.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0056Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Mediator",
        "sourceGroup": "MD-NOME / MD-LOCATION-REF / MD-MORADA1 / MD-MORADA2",
        "targetType": "Entity?",
        "targetPath": "Mediator",
        "decision": "mapped",
        "description": "Optional mediator party identified in BGOW0056.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0056Contract.Mediator",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-MD-NOME                PIC X(40).",
            "sourceField": "MD-NOME",
            "target": "Mediator.MdNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCATION-REF        PIC X(04).",
            "sourceField": "MD-LOCATION-REF",
            "target": "Mediator.MdLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA1             PIC X(40).",
            "sourceField": "MD-MORADA1",
            "target": "Mediator.MdMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA2             PIC X(40).",
            "sourceField": "MD-MORADA2",
            "target": "Mediator.MdMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCALIDADE          PIC X(40).",
            "sourceField": "MD-LOCALIDADE",
            "target": "Mediator.MdLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL             PIC X(09).",
            "sourceField": "MD-CPOSTAL",
            "target": "Mediator.MdCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "MD-CPOSTAL-DESC",
            "target": "Mediator.MdCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPAIS               PIC X(03).",
            "sourceField": "MD-CPAIS",
            "target": "Mediator.MdCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPAIS-DESC          PIC X(40).",
            "sourceField": "MD-CPAIS-DESC",
            "target": "Mediator.MdCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-IDP                 PIC X(04).",
            "sourceField": "MD-IDP",
            "target": "Mediator.MdIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-NIF                 PIC X(22).",
            "sourceField": "MD-NIF",
            "target": "Mediator.MdNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-TIPO-ENTIDADE       PIC X(01).",
            "sourceField": "MD-TIPO-ENTIDADE",
            "target": "Mediator.MdTipoEntidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "NR-AGENTE",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW0056.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0056Contract.Agent",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "Agent.NrAgente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "MD-LOCATION-REF / MD-MORADA1 / MD-MORADA2 / MD-LOCALIDADE",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0056.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0056Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-MD-LOCATION-REF        PIC X(04).",
            "sourceField": "MD-LOCATION-REF",
            "target": "MailingAddress.MdLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA1             PIC X(40).",
            "sourceField": "MD-MORADA1",
            "target": "MailingAddress.MdMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA2             PIC X(40).",
            "sourceField": "MD-MORADA2",
            "target": "MailingAddress.MdMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCALIDADE          PIC X(40).",
            "sourceField": "MD-LOCALIDADE",
            "target": "MailingAddress.MdLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL             PIC X(09).",
            "sourceField": "MD-CPOSTAL",
            "target": "MailingAddress.MdCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "MD-CPOSTAL-DESC",
            "target": "MailingAddress.MdCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "VLR-RECEBER / DT-VLR-DESCR / TT-VALOR",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0056.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0056Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-VLR-RECEBER            PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "VLR-RECEBER",
            "target": "Premium.VlrReceber",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-VLR-DESCR           PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-DESCR",
            "target": "Premium.DtVlrDescr",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TT-VALOR               PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "TT-VALOR",
            "target": "Premium.TtValor",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "TextBlocks",
        "sourceGroup": "DT-DESCRITIVO",
        "targetType": "IReadOnlyList<TextBlock>",
        "targetPath": "TextBlocks",
        "decision": "candidate",
        "description": "Document text, notes, clauses, or message lines identified in BGOW0056.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0056Contract.TextBlocks",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-DESCRITIVO          PIC X(60).",
            "sourceField": "DT-DESCRITIVO",
            "target": "TextBlocks.DtDescritivo",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0056."
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-CARTA / DT-DESCRITIVO / DT-VLR-DESCR / TT-VALOR",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0056.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0056Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-CARTA               PIC X(08).",
            "sourceField": "DT-CARTA",
            "target": "Tables.DtCarta",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0056."
          },
          {
            "source": "09  :PREFIX:-DT-DESCRITIVO          PIC X(60).",
            "sourceField": "DT-DESCRITIVO",
            "target": "Tables.DtDescritivo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0056."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-DESCR           PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-DESCR",
            "target": "Tables.DtVlrDescr",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0056."
          },
          {
            "source": "09  :PREFIX:-TT-VALOR               PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "TT-VALOR",
            "target": "Tables.TtValor",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0056."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REGISTO",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0056.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0056Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REGISTO             PIC X(01).",
            "sourceField": "TIPO-REGISTO",
            "target": "PrintRecordControl.TipoRegisto",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0059",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0059 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.BGOW0059Contract",
    "description": "BGOW0059 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0059Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0059 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1149",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1149."
          },
          {
            "source": null,
            "sourceField": "1150",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1150."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-DOCUMENTO / TIPO-IMPRESSAO / USERID / COD-COMPANHIA",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-DOCUMENTO            PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentInformation.CodDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USERID                   PIC X(08).",
            "sourceField": "USERID",
            "target": "DocumentInformation.Userid",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-AUX-MARCA                PIC X(01).",
            "sourceField": "AUX-MARCA",
            "target": "DocumentInformation.AuxMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "DocumentInformation.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-IND-FLYER                PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "DocumentInformation.IndFlyer",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-MOEDA",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-MOEDA              PIC X(03).",
            "sourceField": "COD-MOEDA",
            "target": "Policy.CodMoeda",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "NR-CLIENTE / CL-NOME / CL-LOCATION-REF / CL-MORADA1",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NOME                PIC X(40).",
            "sourceField": "CL-NOME",
            "target": "Client.ClNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "Client.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "Client.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "Client.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "Client.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "Client.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "Client.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS               PIC X(03).",
            "sourceField": "CL-CPAIS",
            "target": "Client.ClCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS-DESC          PIC X(40).",
            "sourceField": "CL-CPAIS-DESC",
            "target": "Client.ClCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-IDP                 PIC X(04).",
            "sourceField": "CL-IDP",
            "target": "Client.ClIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NIF                 PIC X(22).",
            "sourceField": "CL-NIF",
            "target": "Client.ClNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-TIPO-ENTIDADE       PIC X(01).",
            "sourceField": "CL-TIPO-ENTIDADE",
            "target": "Client.ClTipoEntidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Mediator",
        "sourceGroup": "MD-NOME / MD-LOCATION-REF / MD-MORADA1 / MD-MORADA2",
        "targetType": "Entity?",
        "targetPath": "Mediator",
        "decision": "mapped",
        "description": "Optional mediator party identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.Mediator",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-MD-NOME                PIC X(40).",
            "sourceField": "MD-NOME",
            "target": "Mediator.MdNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCATION-REF        PIC X(04).",
            "sourceField": "MD-LOCATION-REF",
            "target": "Mediator.MdLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA1             PIC X(40).",
            "sourceField": "MD-MORADA1",
            "target": "Mediator.MdMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA2             PIC X(40).",
            "sourceField": "MD-MORADA2",
            "target": "Mediator.MdMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCALIDADE          PIC X(40).",
            "sourceField": "MD-LOCALIDADE",
            "target": "Mediator.MdLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL             PIC X(09).",
            "sourceField": "MD-CPOSTAL",
            "target": "Mediator.MdCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "MD-CPOSTAL-DESC",
            "target": "Mediator.MdCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPAIS               PIC X(03).",
            "sourceField": "MD-CPAIS",
            "target": "Mediator.MdCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPAIS-DESC          PIC X(40).",
            "sourceField": "MD-CPAIS-DESC",
            "target": "Mediator.MdCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-IDP                 PIC X(04).",
            "sourceField": "MD-IDP",
            "target": "Mediator.MdIdp",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "NR-AGENTE",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.Agent",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "Agent.NrAgente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Creditor",
        "sourceGroup": "CH-NR-CHEQUE / CH-DATA-CHEQUE / CH-LINHA-OTICA / CH-EXTENSO-L1",
        "targetType": "Entity?",
        "targetPath": "Creditor",
        "decision": "mapped",
        "description": "Optional creditor or mortgage creditor party identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.Creditor",
            "status": "container"
          },
          {
            "source": "11  :PREFIX:-CH-NR-CHEQUE       PIC X(10).",
            "sourceField": "CH-NR-CHEQUE",
            "target": "Creditor.ChNrCheque",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CH-DATA-CHEQUE     PIC X(08).",
            "sourceField": "CH-DATA-CHEQUE",
            "target": "Creditor.ChDataCheque",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CH-LINHA-OTICA     PIC X(52).",
            "sourceField": "CH-LINHA-OTICA",
            "target": "Creditor.ChLinhaOtica",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CH-EXTENSO-L1      PIC X(100).",
            "sourceField": "CH-EXTENSO-L1",
            "target": "Creditor.ChExtensoL1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CH-EXTENSO-L2      PIC X(100).",
            "sourceField": "CH-EXTENSO-L2",
            "target": "Creditor.ChExtensoL2",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "CL-LOCATION-REF / CL-MORADA1 / CL-MORADA2 / CL-LOCALIDADE",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "MailingAddress.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "MailingAddress.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "MailingAddress.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "MailingAddress.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "MailingAddress.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "MailingAddress.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCATION-REF        PIC X(04).",
            "sourceField": "MD-LOCATION-REF",
            "target": "MailingAddress.MdLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA1             PIC X(40).",
            "sourceField": "MD-MORADA1",
            "target": "MailingAddress.MdMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA2             PIC X(40).",
            "sourceField": "MD-MORADA2",
            "target": "MailingAddress.MdMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCALIDADE          PIC X(40).",
            "sourceField": "MD-LOCALIDADE",
            "target": "MailingAddress.MdLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL             PIC X(09).",
            "sourceField": "MD-CPOSTAL",
            "target": "MailingAddress.MdCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "MD-CPOSTAL-DESC",
            "target": "MailingAddress.MdCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "PaymentAccount",
        "sourceGroup": "DEB-NOME-BANCO / DEB-IBAN / DEB-SWIFT",
        "targetType": "BankAccount?",
        "targetPath": "PaymentAccount",
        "decision": "mapped",
        "description": "Bank-account payment details identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.PaymentAccount",
            "status": "container"
          },
          {
            "source": "11  :PREFIX:-DEB-NOME-BANCO     PIC X(60).",
            "sourceField": "DEB-NOME-BANCO",
            "target": "PaymentAccount.DebNomeBanco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-DEB-IBAN           PIC X(34).",
            "sourceField": "DEB-IBAN",
            "target": "PaymentAccount.DebIban",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-DEB-SWIFT          PIC X(11).",
            "sourceField": "DEB-SWIFT",
            "target": "PaymentAccount.DebSwift",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "DT-VLR-ORDEM-PAG",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-VLR-ORDEM-PAG       PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-ORDEM-PAG",
            "target": "Premium.DtVlrOrdemPag",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "TextBlocks",
        "sourceGroup": "CH-LINHA-OTICA",
        "targetType": "IReadOnlyList<TextBlock>",
        "targetPath": "TextBlocks",
        "decision": "candidate",
        "description": "Document text, notes, clauses, or message lines identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.TextBlocks",
            "status": "container"
          },
          {
            "source": "11  :PREFIX:-CH-LINHA-OTICA     PIC X(52).",
            "sourceField": "CH-LINHA-OTICA",
            "target": "TextBlocks.ChLinhaOtica",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0059."
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-EMISSAO / DT-CREDITO / DT-VLR-ORDEM-PAG",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-EMISSAO             PIC X(08).",
            "sourceField": "DT-EMISSAO",
            "target": "Tables.DtEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0059."
          },
          {
            "source": "09  :PREFIX:-DT-CREDITO             PIC X(08).",
            "sourceField": "DT-CREDITO",
            "target": "Tables.DtCredito",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0059."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-ORDEM-PAG       PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-ORDEM-PAG",
            "target": "Tables.DtVlrOrdemPag",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0059."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REGISTO",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0059.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0059Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REGISTO             PIC X(01).",
            "sourceField": "TIPO-REGISTO",
            "target": "PrintRecordControl.TipoRegisto",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0060",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0060 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.BGOW0060Contract",
    "description": "BGOW0060 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0060Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0060 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1241",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1241."
          },
          {
            "source": null,
            "sourceField": "1255",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1255."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-DOCUMENTO / TIPO-IMPRESSAO / USERID / COD-COMPANHIA",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0060.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0060Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-DOCUMENTO            PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentInformation.CodDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USERID                   PIC X(08).",
            "sourceField": "USERID",
            "target": "DocumentInformation.Userid",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-AUX-MARCA                PIC X(01).",
            "sourceField": "AUX-MARCA",
            "target": "DocumentInformation.AuxMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "DocumentInformation.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-IND-FLYER                PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "DocumentInformation.IndFlyer",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-NR-APOLICE        PIC X(16).",
            "sourceField": "DT-NR-APOLICE",
            "target": "DocumentInformation.DtNrApolice",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-MOEDA / DT-NR-APOLICE",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0060.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0060Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-MOEDA            PIC X(03).",
            "sourceField": "COD-MOEDA",
            "target": "Policy.CodMoeda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-NR-APOLICE        PIC X(16).",
            "sourceField": "DT-NR-APOLICE",
            "target": "Policy.DtNrApolice",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "NR-CLIENTE",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0060.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0060Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Mediator",
        "sourceGroup": "MD-NOME / MD-LOCATION-REF / MD-MORADA1 / MD-MORADA2",
        "targetType": "Entity?",
        "targetPath": "Mediator",
        "decision": "mapped",
        "description": "Optional mediator party identified in BGOW0060.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0060Contract.Mediator",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-MD-NOME              PIC X(40).",
            "sourceField": "MD-NOME",
            "target": "Mediator.MdNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCATION-REF      PIC X(04).",
            "sourceField": "MD-LOCATION-REF",
            "target": "Mediator.MdLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA1           PIC X(40).",
            "sourceField": "MD-MORADA1",
            "target": "Mediator.MdMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA2           PIC X(40).",
            "sourceField": "MD-MORADA2",
            "target": "Mediator.MdMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCALIDADE        PIC X(40).",
            "sourceField": "MD-LOCALIDADE",
            "target": "Mediator.MdLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL           PIC X(09).",
            "sourceField": "MD-CPOSTAL",
            "target": "Mediator.MdCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL-DESC      PIC X(40).",
            "sourceField": "MD-CPOSTAL-DESC",
            "target": "Mediator.MdCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPAIS             PIC X(03).",
            "sourceField": "MD-CPAIS",
            "target": "Mediator.MdCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPAIS-DESC        PIC X(40).",
            "sourceField": "MD-CPAIS-DESC",
            "target": "Mediator.MdCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-IDP               PIC X(04).",
            "sourceField": "MD-IDP",
            "target": "Mediator.MdIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-NIF               PIC X(22).",
            "sourceField": "MD-NIF",
            "target": "Mediator.MdNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-TIPO-ENTIDADE     PIC X(01).",
            "sourceField": "MD-TIPO-ENTIDADE",
            "target": "Mediator.MdTipoEntidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "NR-AGENTE",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW0060.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0060Contract.Agent",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "Agent.NrAgente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "MD-LOCATION-REF / MD-MORADA1 / MD-MORADA2 / MD-LOCALIDADE",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0060.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0060Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-MD-LOCATION-REF      PIC X(04).",
            "sourceField": "MD-LOCATION-REF",
            "target": "MailingAddress.MdLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA1           PIC X(40).",
            "sourceField": "MD-MORADA1",
            "target": "MailingAddress.MdMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA2           PIC X(40).",
            "sourceField": "MD-MORADA2",
            "target": "MailingAddress.MdMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCALIDADE        PIC X(40).",
            "sourceField": "MD-LOCALIDADE",
            "target": "MailingAddress.MdLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL           PIC X(09).",
            "sourceField": "MD-CPOSTAL",
            "target": "MailingAddress.MdCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL-DESC      PIC X(40).",
            "sourceField": "MD-CPOSTAL-DESC",
            "target": "MailingAddress.MdCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "DT-VLR-REC / DT-VLR-COM / DT-VLR-IRS / DT-VLR-SEL",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0060.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0060Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-VLR-REC           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-REC",
            "target": "Premium.DtVlrRec",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-VLR-COM           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-COM",
            "target": "Premium.DtVlrCom",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-VLR-IRS           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-IRS",
            "target": "Premium.DtVlrIrs",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-VLR-SEL           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-SEL",
            "target": "Premium.DtVlrSel",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-VLR-SEG           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-SEG",
            "target": "Premium.DtVlrSeg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-VLR-OUT           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-OUT",
            "target": "Premium.DtVlrOut",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TR-SI-VALOR      PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TR-SI-VALOR",
            "target": "Premium.TrSiValor",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TR-VLR-REC       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TR-VLR-REC",
            "target": "Premium.TrVlrRec",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TR-VLR-COM       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TR-VLR-COM",
            "target": "Premium.TrVlrCom",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TR-VLR-IRS       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TR-VLR-IRS",
            "target": "Premium.TrVlrIrs",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TR-VLR-SEL       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TR-VLR-SEL",
            "target": "Premium.TrVlrSel",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TR-VLR-SEG       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TR-VLR-SEG",
            "target": "Premium.TrVlrSeg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TR-VLR-OUT       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TR-VLR-OUT",
            "target": "Premium.TrVlrOut",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TR-SF-VALOR      PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TR-SF-VALOR",
            "target": "Premium.TrSfValor",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TA-VLR-COM       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TA-VLR-COM",
            "target": "Premium.TaVlrCom",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TA-VLR-IRS       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TA-VLR-IRS",
            "target": "Premium.TaVlrIrs",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TA-VLR-SEL       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TA-VLR-SEL",
            "target": "Premium.TaVlrSel",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-TA-VLR-SEG       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TA-VLR-SEG",
            "target": "Premium.TaVlrSeg",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-EMISSAO / DT-DATA / DT-HORA / DT-REFERENCIA",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0060Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-EMISSAO           PIC X(08).",
            "sourceField": "DT-EMISSAO",
            "target": "Tables.DtEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-DATA              PIC X(08).",
            "sourceField": "DT-DATA",
            "target": "Tables.DtData",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-HORA              PIC X(06).",
            "sourceField": "DT-HORA",
            "target": "Tables.DtHora",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-REFERENCIA        PIC X(50).",
            "sourceField": "DT-REFERENCIA",
            "target": "Tables.DtReferencia",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-TIPO-MOVIMENTO    PIC X(50).",
            "sourceField": "DT-TIPO-MOVIMENTO",
            "target": "Tables.DtTipoMovimento",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-NR-APOLICE        PIC X(16).",
            "sourceField": "DT-NR-APOLICE",
            "target": "Tables.DtNrApolice",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-NR-SINISTRO       PIC X(12).",
            "sourceField": "DT-NR-SINISTRO",
            "target": "Tables.DtNrSinistro",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-NR-RECIBO         PIC X(16).",
            "sourceField": "DT-NR-RECIBO",
            "target": "Tables.DtNrRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-TIPO              PIC X(12).",
            "sourceField": "DT-TIPO",
            "target": "Tables.DtTipo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-REC           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-REC",
            "target": "Tables.DtVlrRec",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-COM           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-COM",
            "target": "Tables.DtVlrCom",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-IRS           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-IRS",
            "target": "Tables.DtVlrIrs",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-SEL           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-SEL",
            "target": "Tables.DtVlrSel",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-SEG           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-SEG",
            "target": "Tables.DtVlrSeg",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-OUT           PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-OUT",
            "target": "Tables.DtVlrOut",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "11  :PREFIX:-TR-SI-DATA       PIC X(08).",
            "sourceField": "TR-SI-DATA",
            "target": "Tables.TrSiData",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "11  :PREFIX:-TR-SI-VALOR      PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TR-SI-VALOR",
            "target": "Tables.TrSiValor",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          },
          {
            "source": "11  :PREFIX:-TR-VLR-REC       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "TR-VLR-REC",
            "target": "Tables.TrVlrRec",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REGISTO",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0060.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0060Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REGISTO             PIC X(01).",
            "sourceField": "TIPO-REGISTO",
            "target": "PrintRecordControl.TipoRegisto",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0062",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0062 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.BGOW0062Contract",
    "description": "BGOW0062 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0062Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0062 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1050",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1050."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-DOCUMENTO / TIPO-IMPRESSAO / USERID / COD-COMPANHIA",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0062Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-DOCUMENTO            PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentInformation.CodDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USERID                   PIC X(08).",
            "sourceField": "USERID",
            "target": "DocumentInformation.Userid",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-AUX-MARCA                PIC X(01).",
            "sourceField": "AUX-MARCA",
            "target": "DocumentInformation.AuxMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "DocumentInformation.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-IND-FLYER                PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "DocumentInformation.IndFlyer",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-NR-APOLICE        PIC X(16).",
            "sourceField": "DT-NR-APOLICE",
            "target": "DocumentInformation.DtNrApolice",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-MOEDA / DT-RAMO / DT-DESCR-RAMO",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0062Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-MOEDA            PIC X(03).",
            "sourceField": "COD-MOEDA",
            "target": "Policy.CodMoeda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-RAMO              PIC X(10).",
            "sourceField": "DT-RAMO",
            "target": "Policy.DtRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-DESCR-RAMO        PIC X(40).",
            "sourceField": "DT-DESCR-RAMO",
            "target": "Policy.DtDescrRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-NR-APOLICE        PIC X(16).",
            "sourceField": "DT-NR-APOLICE",
            "target": "Policy.DtNrApolice",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "NR-CLIENTE",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0062Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Mediator",
        "sourceGroup": "MD-NOME / MD-LOCATION-REF / MD-MORADA1 / MD-MORADA2",
        "targetType": "Entity?",
        "targetPath": "Mediator",
        "decision": "mapped",
        "description": "Optional mediator party identified in BGOW0062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0062Contract.Mediator",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-MD-NOME              PIC X(40).",
            "sourceField": "MD-NOME",
            "target": "Mediator.MdNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCATION-REF      PIC X(04).",
            "sourceField": "MD-LOCATION-REF",
            "target": "Mediator.MdLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA1           PIC X(40).",
            "sourceField": "MD-MORADA1",
            "target": "Mediator.MdMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA2           PIC X(40).",
            "sourceField": "MD-MORADA2",
            "target": "Mediator.MdMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCALIDADE        PIC X(40).",
            "sourceField": "MD-LOCALIDADE",
            "target": "Mediator.MdLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL           PIC X(09).",
            "sourceField": "MD-CPOSTAL",
            "target": "Mediator.MdCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL-DESC      PIC X(40).",
            "sourceField": "MD-CPOSTAL-DESC",
            "target": "Mediator.MdCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPAIS             PIC X(03).",
            "sourceField": "MD-CPAIS",
            "target": "Mediator.MdCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPAIS-DESC        PIC X(40).",
            "sourceField": "MD-CPAIS-DESC",
            "target": "Mediator.MdCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-IDP               PIC X(04).",
            "sourceField": "MD-IDP",
            "target": "Mediator.MdIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-NIF               PIC X(22).",
            "sourceField": "MD-NIF",
            "target": "Mediator.MdNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-TIPO-ENTIDADE     PIC X(01).",
            "sourceField": "MD-TIPO-ENTIDADE",
            "target": "Mediator.MdTipoEntidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "NR-AGENTE",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW0062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0062Contract.Agent",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "Agent.NrAgente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "MD-LOCATION-REF / MD-MORADA1 / MD-MORADA2 / MD-LOCALIDADE",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0062Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-MD-LOCATION-REF      PIC X(04).",
            "sourceField": "MD-LOCATION-REF",
            "target": "MailingAddress.MdLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA1           PIC X(40).",
            "sourceField": "MD-MORADA1",
            "target": "MailingAddress.MdMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-MORADA2           PIC X(40).",
            "sourceField": "MD-MORADA2",
            "target": "MailingAddress.MdMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-LOCALIDADE        PIC X(40).",
            "sourceField": "MD-LOCALIDADE",
            "target": "MailingAddress.MdLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL           PIC X(09).",
            "sourceField": "MD-CPOSTAL",
            "target": "MailingAddress.MdCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MD-CPOSTAL-DESC      PIC X(40).",
            "sourceField": "MD-CPOSTAL-DESC",
            "target": "MailingAddress.MdCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "DT-VLR-PRM / DT-VLR-REC / TT-VLR-REC",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0062Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-VLR-PRM           PIC S9(12)V9(2)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-PRM",
            "target": "Premium.DtVlrPrm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DT-VLR-REC           PIC S9(12)V9(2)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-REC",
            "target": "Premium.DtVlrRec",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TT-VLR-REC           PIC S9(12)V9(2)  SIGN LEADING SEPARATE.",
            "sourceField": "TT-VLR-REC",
            "target": "Premium.TtVlrRec",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-EMISSAO / DT-NOME / DT-RAMO / DT-DESCR-RAMO",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0062Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-EMISSAO           PIC X(08).",
            "sourceField": "DT-EMISSAO",
            "target": "Tables.DtEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-NOME              PIC X(40).",
            "sourceField": "DT-NOME",
            "target": "Tables.DtNome",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-RAMO              PIC X(10).",
            "sourceField": "DT-RAMO",
            "target": "Tables.DtRamo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-DESCR-RAMO        PIC X(40).",
            "sourceField": "DT-DESCR-RAMO",
            "target": "Tables.DtDescrRamo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-NR-APOLICE        PIC X(16).",
            "sourceField": "DT-NR-APOLICE",
            "target": "Tables.DtNrApolice",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-NR-SINISTRO       PIC X(12).",
            "sourceField": "DT-NR-SINISTRO",
            "target": "Tables.DtNrSinistro",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-NR-RECIBO         PIC X(11).",
            "sourceField": "DT-NR-RECIBO",
            "target": "Tables.DtNrRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-TIPO-RECIBO       PIC X(12).",
            "sourceField": "DT-TIPO-RECIBO",
            "target": "Tables.DtTipoRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-DATA-EMISSAO      PIC X(08).",
            "sourceField": "DT-DATA-EMISSAO",
            "target": "Tables.DtDataEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-DATA-INICIO       PIC X(08).",
            "sourceField": "DT-DATA-INICIO",
            "target": "Tables.DtDataInicio",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-DATA-FIM          PIC X(08).",
            "sourceField": "DT-DATA-FIM",
            "target": "Tables.DtDataFim",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-DATA-DEVIDO       PIC X(08).",
            "sourceField": "DT-DATA-DEVIDO",
            "target": "Tables.DtDataDevido",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-PRM           PIC S9(12)V9(2)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-PRM",
            "target": "Tables.DtVlrPrm",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-VLR-REC           PIC S9(12)V9(2)  SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-REC",
            "target": "Tables.DtVlrRec",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-DT-NUM-DIAS          PIC X(05).",
            "sourceField": "DT-NUM-DIAS",
            "target": "Tables.DtNumDias",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          },
          {
            "source": "09  :PREFIX:-TT-VLR-REC           PIC S9(12)V9(2)  SIGN LEADING SEPARATE.",
            "sourceField": "TT-VLR-REC",
            "target": "Tables.TtVlrRec",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REGISTO",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0062Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REGISTO             PIC X(01).",
            "sourceField": "TIPO-REGISTO",
            "target": "PrintRecordControl.TipoRegisto",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0068",
    "originSystem": "GIS",
    "title": "GIS BGOW0068 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.GIS.BGOW0068Contract",
    "description": "BGOW0068 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0068Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0068 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1316",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1316."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-COMPANHIA / COD-MARCA / COD-ORIGEM / NR-MEDIADOR",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0068.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0068Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-MEDIADOR              PIC X(10).",
            "sourceField": "NR-MEDIADOR",
            "target": "DocumentInformation.NrMediador",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-PRODUTO              PIC X(06).",
            "sourceField": "COD-PRODUTO",
            "target": "DocumentInformation.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-DATA-HORA                PIC X(14).",
            "sourceField": "DATA-HORA",
            "target": "DocumentInformation.DataHora",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(03).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-DOC-ID                   PIC X(03).",
            "sourceField": "DOC-ID",
            "target": "DocumentInformation.DocId",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USER-ID                  PIC X(08).",
            "sourceField": "USER-ID",
            "target": "DocumentInformation.UserId",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-PRODUTO / ADERENTE / DA-PRODUTO-DESC",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0068.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0068Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-PRODUTO              PIC X(06).",
            "sourceField": "COD-PRODUTO",
            "target": "Policy.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-ADERENTE                 PIC X(08).",
            "sourceField": "ADERENTE",
            "target": "Policy.Aderente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DA-PRODUTO-DESC        PIC X(40).",
            "sourceField": "DA-PRODUTO-DESC",
            "target": "Policy.DaProdutoDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "COD-POSTALC / NR-CLIENTE / TM-NOME / TM-LOCATION-REF",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0068.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0068Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-POSTALC              PIC X(09).",
            "sourceField": "COD-POSTALC",
            "target": "Client.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-NOME                PIC X(40).",
            "sourceField": "TM-NOME",
            "target": "Client.TmNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCATION-REF        PIC X(04).",
            "sourceField": "TM-LOCATION-REF",
            "target": "Client.TmLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA1             PIC X(40).",
            "sourceField": "TM-MORADA1",
            "target": "Client.TmMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA2             PIC X(40).",
            "sourceField": "TM-MORADA2",
            "target": "Client.TmMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCALIDADE          PIC X(40).",
            "sourceField": "TM-LOCALIDADE",
            "target": "Client.TmLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL             PIC X(09).",
            "sourceField": "TM-CPOSTAL",
            "target": "Client.TmCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "TM-CPOSTAL-DESC",
            "target": "Client.TmCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPAIS               PIC X(03).",
            "sourceField": "TM-CPAIS",
            "target": "Client.TmCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPAIS-DESC          PIC X(40).",
            "sourceField": "TM-CPAIS-DESC",
            "target": "Client.TmCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-IDP                 PIC X(04).",
            "sourceField": "TM-IDP",
            "target": "Client.TmIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-NIF                 PIC X(22).",
            "sourceField": "TM-NIF",
            "target": "Client.TmNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-TIPO-ENTIDADE       PIC X(01).",
            "sourceField": "TM-TIPO-ENTIDADE",
            "target": "Client.TmTipoEntidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Mediator",
        "sourceGroup": "COD-POSTALM / NR-MEDIADOR",
        "targetType": "Entity?",
        "targetPath": "Mediator",
        "decision": "mapped",
        "description": "Optional mediator party identified in BGOW0068.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0068Contract.Mediator",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-POSTALM              PIC X(09).",
            "sourceField": "COD-POSTALM",
            "target": "Mediator.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-MEDIADOR              PIC X(10).",
            "sourceField": "NR-MEDIADOR",
            "target": "Mediator.NrMediador",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "COD-POSTALM / COD-POSTALC / TM-LOCATION-REF / TM-MORADA1",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0068.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0068Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-POSTALM              PIC X(09).",
            "sourceField": "COD-POSTALM",
            "target": "MailingAddress.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-POSTALC              PIC X(09).",
            "sourceField": "COD-POSTALC",
            "target": "MailingAddress.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCATION-REF        PIC X(04).",
            "sourceField": "TM-LOCATION-REF",
            "target": "MailingAddress.TmLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA1             PIC X(40).",
            "sourceField": "TM-MORADA1",
            "target": "MailingAddress.TmMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA2             PIC X(40).",
            "sourceField": "TM-MORADA2",
            "target": "MailingAddress.TmMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCALIDADE          PIC X(40).",
            "sourceField": "TM-LOCALIDADE",
            "target": "MailingAddress.TmLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL             PIC X(09).",
            "sourceField": "TM-CPOSTAL",
            "target": "MailingAddress.TmCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "TM-CPOSTAL-DESC",
            "target": "MailingAddress.TmCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "PC-PARCELA-DESC / PC-PARCELA-VALOR / PA-PARCELA-DESC / PA-PARCELA-VALOR",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0068.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0068Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-PC-PARCELA-DESC        PIC X(100).",
            "sourceField": "PC-PARCELA-DESC",
            "target": "Premium.PcParcelaDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PC-PARCELA-VALOR       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "PC-PARCELA-VALOR",
            "target": "Premium.PcParcelaValor",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PA-PARCELA-DESC        PIC X(100).",
            "sourceField": "PA-PARCELA-DESC",
            "target": "Premium.PaParcelaDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PA-PARCELA-VALOR       PIC S9(12)V9(02)  SIGN LEADING SEPARATE.",
            "sourceField": "PA-PARCELA-VALOR",
            "target": "Premium.PaParcelaValor",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "RiskUnit",
        "sourceGroup": "PS-NOME",
        "targetType": "RiskUnit",
        "targetPath": "RiskUnit",
        "decision": "mapped",
        "description": "Insured object, insured person, or risk-unit data identified in BGOW0068.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0068Contract.RiskUnit",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-PS-NOME                PIC X(50).",
            "sourceField": "PS-NOME",
            "target": "RiskUnit.PsNome",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "IF-IND-NOVA-COB / IF-IND-ALT-TARIF",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0068.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0068Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-IF-IND-NOVA-COB        PIC X(01).",
            "sourceField": "IF-IND-NOVA-COB",
            "target": "Tables.IfIndNovaCob",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0068."
          },
          {
            "source": "09  :PREFIX:-IF-IND-ALT-TARIF       PIC X(01).",
            "sourceField": "IF-IND-ALT-TARIF",
            "target": "Tables.IfIndAltTarif",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0068."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REG / DOC-ID",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0068.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0068Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REG                 PIC X(04).",
            "sourceField": "TIPO-REG",
            "target": "PrintRecordControl.TipoReg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-DOC-ID                   PIC X(03).",
            "sourceField": "DOC-ID",
            "target": "PrintRecordControl.DocId",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0070",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0070 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.BGOW0070Contract",
    "description": "BGOW0070 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0070Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0070 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1317",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1317."
          },
          {
            "source": null,
            "sourceField": "1318",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1318."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-DOCUMENTO / TIPO-IMPRESSAO / USERID / COD-COMPANHIA",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0070.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0070Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-DOCUMENTO            PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentInformation.CodDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USERID                   PIC X(08).",
            "sourceField": "USERID",
            "target": "DocumentInformation.Userid",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-AUX-MARCA                PIC X(01).",
            "sourceField": "AUX-MARCA",
            "target": "DocumentInformation.AuxMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "DocumentInformation.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-IND-FLYER                PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "DocumentInformation.IndFlyer",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TIPO-DOCUMENTO         PIC X(01).",
            "sourceField": "TIPO-DOCUMENTO",
            "target": "DocumentInformation.TipoDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-PRODUTO            PIC X(10).",
            "sourceField": "COD-PRODUTO",
            "target": "DocumentInformation.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VH-MARCA             PIC X(30).",
            "sourceField": "VH-MARCA",
            "target": "DocumentInformation.VhMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-NR-APOLICE          PIC X(16).",
            "sourceField": "TA-NR-APOLICE",
            "target": "DocumentInformation.TaNrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-COD-PRODUTO         PIC X(10).",
            "sourceField": "TA-COD-PRODUTO",
            "target": "DocumentInformation.TaCodProduto",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-MOEDA / COD-PRODUTO / COD-RAMO",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0070.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0070Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-MOEDA              PIC X(03).",
            "sourceField": "COD-MOEDA",
            "target": "Policy.CodMoeda",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-PRODUTO            PIC X(10).",
            "sourceField": "COD-PRODUTO",
            "target": "Policy.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-RAMO               PIC X(10).",
            "sourceField": "COD-RAMO",
            "target": "Policy.CodRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DESCR-RAMO-PROD        PIC X(40).",
            "sourceField": "DESCR-RAMO-PROD",
            "target": "Policy.DescrRamoProd",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VI-TIPO-APOLICE        PIC X(02).",
            "sourceField": "VI-TIPO-APOLICE",
            "target": "Policy.ViTipoApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-ADERENTE            PIC X(08).",
            "sourceField": "PS-ADERENTE",
            "target": "Policy.PsAderente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-NR-APOLICE          PIC X(16).",
            "sourceField": "TA-NR-APOLICE",
            "target": "Policy.TaNrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-COD-PRODUTO         PIC X(10).",
            "sourceField": "TA-COD-PRODUTO",
            "target": "Policy.TaCodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-COD-RAMO            PIC X(10).",
            "sourceField": "TA-COD-RAMO",
            "target": "Policy.TaCodRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-DESCR-RAMO-PROD     PIC X(40).",
            "sourceField": "TA-DESCR-RAMO-PROD",
            "target": "Policy.TaDescrRamoProd",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TA-VI-TIPO-APOLICE     PIC X(02).",
            "sourceField": "TA-VI-TIPO-APOLICE",
            "target": "Policy.TaViTipoApolice",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "NR-CLIENTE / CL-NOME / CL-LOCATION-REF / CL-MORADA1",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0070.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0070Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NOME                PIC X(40).",
            "sourceField": "CL-NOME",
            "target": "Client.ClNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "Client.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "Client.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "Client.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "Client.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "Client.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "Client.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS               PIC X(03).",
            "sourceField": "CL-CPAIS",
            "target": "Client.ClCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS-DESC          PIC X(40).",
            "sourceField": "CL-CPAIS-DESC",
            "target": "Client.ClCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-IDP                 PIC X(04).",
            "sourceField": "CL-IDP",
            "target": "Client.ClIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NIF                 PIC X(22).",
            "sourceField": "CL-NIF",
            "target": "Client.ClNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-TIPO-ENTIDADE       PIC X(01).",
            "sourceField": "CL-TIPO-ENTIDADE",
            "target": "Client.ClTipoEntidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "NR-AGENTE",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW0070.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0070Contract.Agent",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "Agent.NrAgente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "CL-LOCATION-REF / CL-MORADA1 / CL-MORADA2 / CL-LOCALIDADE",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0070.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0070Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "MailingAddress.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "MailingAddress.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "MailingAddress.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "MailingAddress.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "MailingAddress.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "MailingAddress.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MR-MORADA1             PIC X(40).",
            "sourceField": "MR-MORADA1",
            "target": "MailingAddress.MrMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MR-MORADA2             PIC X(40).",
            "sourceField": "MR-MORADA2",
            "target": "MailingAddress.MrMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MR-LOCALIDADE          PIC X(40).",
            "sourceField": "MR-LOCALIDADE",
            "target": "MailingAddress.MrLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MR-CPOSTAL             PIC X(09).",
            "sourceField": "MR-CPOSTAL",
            "target": "MailingAddress.MrCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MR-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "MR-CPOSTAL-DESC",
            "target": "MailingAddress.MrCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "VLR-CAPITAL-RECIBO / VLR-PREMIO-RISCO / VLR-BONIFICACAO / VLR-TOTAL-RECIBO",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0070.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0070Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-VLR-CAPITAL-RECIBO     PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-CAPITAL-RECIBO",
            "target": "Premium.VlrCapitalRecibo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-PREMIO-RISCO       PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-PREMIO-RISCO",
            "target": "Premium.VlrPremioRisco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-BONIFICACAO        PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-BONIFICACAO",
            "target": "Premium.VlrBonificacao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-TOTAL-RECIBO       PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-TOTAL-RECIBO",
            "target": "Premium.VlrTotalRecibo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FRACC              PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FRACC",
            "target": "Premium.VlrFracc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FAT                PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FAT",
            "target": "Premium.VlrFat",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FGA                PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FGA",
            "target": "Premium.VlrFga",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-SNB                PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-SNB",
            "target": "Premium.VlrSnb",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-INEM               PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-INEM",
            "target": "Premium.VlrInem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-CVERDE             PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-CVERDE",
            "target": "Premium.VlrCverde",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-SELOS              PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-SELOS",
            "target": "Premium.VlrSelos",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-ACTA               PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-ACTA",
            "target": "Premium.VlrActa",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-IMP-SELO           PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-IMP-SELO",
            "target": "Premium.VlrImpSelo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FUND-CALAM         PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FUND-CALAM",
            "target": "Premium.VlrFundCalam",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FGA-OCOBERT        PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FGA-OCOBERT",
            "target": "Premium.VlrFgaOcobert",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-FGA-RCIVIL         PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-FGA-RCIVIL",
            "target": "Premium.VlrFgaRcivil",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-BONUS              PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-BONUS",
            "target": "Premium.VlrBonus",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-PR-SIMPLES         PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-PR-SIMPLES",
            "target": "Premium.VlrPrSimples",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "RiskUnit",
        "sourceGroup": "VLR-PREMIO-RISCO / UR-QUANT / UR-TIPO / PS-1-NOME",
        "targetType": "RiskUnit",
        "targetPath": "RiskUnit",
        "decision": "mapped",
        "description": "Insured object, insured person, or risk-unit data identified in BGOW0070.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0070Contract.RiskUnit",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-VLR-PREMIO-RISCO       PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-PREMIO-RISCO",
            "target": "RiskUnit.VlrPremioRisco",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-UR-QUANT               PIC 9(05).",
            "sourceField": "UR-QUANT",
            "target": "RiskUnit.UrQuant",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-UR-TIPO                PIC X(02).",
            "sourceField": "UR-TIPO",
            "target": "RiskUnit.UrTipo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-1-NOME              PIC X(50).",
            "sourceField": "PS-1-NOME",
            "target": "RiskUnit.Ps1Nome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-1-NIF               PIC X(22).",
            "sourceField": "PS-1-NIF",
            "target": "RiskUnit.Ps1Nif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-1-DT-NASC           PIC X(08).",
            "sourceField": "PS-1-DT-NASC",
            "target": "RiskUnit.Ps1DtNasc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-2-NOME              PIC X(50).",
            "sourceField": "PS-2-NOME",
            "target": "RiskUnit.Ps2Nome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-2-NIF               PIC X(22).",
            "sourceField": "PS-2-NIF",
            "target": "RiskUnit.Ps2Nif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-2-DT-NASC           PIC X(08).",
            "sourceField": "PS-2-DT-NASC",
            "target": "RiskUnit.Ps2DtNasc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VH-MARCA             PIC X(30).",
            "sourceField": "VH-MARCA",
            "target": "RiskUnit.VhMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VH-MODELO            PIC X(10).",
            "sourceField": "VH-MODELO",
            "target": "RiskUnit.VhModelo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VH-VERSAO            PIC X(25).",
            "sourceField": "VH-VERSAO",
            "target": "RiskUnit.VhVersao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VH-MATRICULA         PIC X(15).",
            "sourceField": "VH-MATRICULA",
            "target": "RiskUnit.VhMatricula",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VG-CARTA-COND        PIC X(25).",
            "sourceField": "VG-CARTA-COND",
            "target": "RiskUnit.VgCartaCond",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VG-CATEGORIA         PIC X(40).",
            "sourceField": "VG-CATEGORIA",
            "target": "RiskUnit.VgCategoria",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-VO-OBJETO            PIC X(65).",
            "sourceField": "VO-OBJETO",
            "target": "RiskUnit.VoObjeto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MR-OBJETO              PIC X(10).",
            "sourceField": "MR-OBJETO",
            "target": "RiskUnit.MrObjeto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-MR-MORADA1             PIC X(40).",
            "sourceField": "MR-MORADA1",
            "target": "RiskUnit.MrMorada1",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "TextBlocks",
        "sourceGroup": "MR-IND-TEXT-FRENT / MR-IND-TEXT-VERSO / MR-TEXT-FRENT / AT-IND-TEXT-FRENT",
        "targetType": "IReadOnlyList<TextBlock>",
        "targetPath": "TextBlocks",
        "decision": "candidate",
        "description": "Document text, notes, clauses, or message lines identified in BGOW0070.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0070Contract.TextBlocks",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-MR-IND-TEXT-FRENT      PIC X(01).",
            "sourceField": "MR-IND-TEXT-FRENT",
            "target": "TextBlocks.MrIndTextFrent",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-MR-IND-TEXT-VERSO      PIC X(02).",
            "sourceField": "MR-IND-TEXT-VERSO",
            "target": "TextBlocks.MrIndTextVerso",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-MR-TEXT-FRENT          PIC X(60).",
            "sourceField": "MR-TEXT-FRENT",
            "target": "TextBlocks.MrTextFrent",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-AT-IND-TEXT-FRENT      PIC X(01).",
            "sourceField": "AT-IND-TEXT-FRENT",
            "target": "TextBlocks.AtIndTextFrent",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-AT-TEXT-FRENT          PIC X(60).",
            "sourceField": "AT-TEXT-FRENT",
            "target": "TextBlocks.AtTextFrent",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-MS-INDIC-MENSAGENS     PIC X(01).",
            "sourceField": "MS-INDIC-MENSAGENS",
            "target": "TextBlocks.MsIndicMensagens",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW0070."
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-INI-RECI / DT-FIM-RECI / DT-CRI-RECI / DT-LIM-PAG",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0070Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-INI-RECI            PIC X(08).",
            "sourceField": "DT-INI-RECI",
            "target": "Tables.DtIniReci",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-DT-FIM-RECI            PIC X(08).",
            "sourceField": "DT-FIM-RECI",
            "target": "Tables.DtFimReci",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-DT-CRI-RECI            PIC X(08).",
            "sourceField": "DT-CRI-RECI",
            "target": "Tables.DtCriReci",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-DT-LIM-PAG             PIC X(08).",
            "sourceField": "DT-LIM-PAG",
            "target": "Tables.DtLimPag",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-DT-LIM-DEVOL           PIC X(08).",
            "sourceField": "DT-LIM-DEVOL",
            "target": "Tables.DtLimDevol",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-DT-CESSACAO            PIC X(08).",
            "sourceField": "DT-CESSACAO",
            "target": "Tables.DtCessacao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-VLR-TOTAL-RECIBO       PIC S9(12)V9(02)\n                                            SIGN LEADING SEPARATE.",
            "sourceField": "VLR-TOTAL-RECIBO",
            "target": "Tables.VlrTotalRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "07  :PREFIX:-DADOS-EXTRATO            PIC X(32).",
            "sourceField": "DADOS-EXTRATO",
            "target": "Tables.DadosExtrato",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "09  :PREFIX:-DT-IND-APOL-AGREGADA   PIC X(01).",
            "sourceField": "DT-IND-APOL-AGREGADA",
            "target": "Tables.DtIndApolAgregada",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-CAPITAL-RECIBO PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-CAPITAL-RECIBO",
            "target": "Tables.DtVlrCapitalRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-PREMIO-RISCO   PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-PREMIO-RISCO",
            "target": "Tables.DtVlrPremioRisco",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-BONIFICACAO    PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-BONIFICACAO",
            "target": "Tables.DtVlrBonificacao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-TOTAL-RECIBO   PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-TOTAL-RECIBO",
            "target": "Tables.DtVlrTotalRecibo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-FRACC          PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-FRACC",
            "target": "Tables.DtVlrFracc",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-FAT            PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-FAT",
            "target": "Tables.DtVlrFat",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-FGA            PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-FGA",
            "target": "Tables.DtVlrFga",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-SNB            PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-SNB",
            "target": "Tables.DtVlrSnb",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          },
          {
            "source": "11  :PREFIX:-DT-VLR-INEM           PIC S9(12)V9(02)\n                                             SIGN LEADING SEPARATE.",
            "sourceField": "DT-VLR-INEM",
            "target": "Tables.DtVlrInem",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REGISTO",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0070.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0070Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REGISTO             PIC X(01).",
            "sourceField": "TIPO-REGISTO",
            "target": "PrintRecordControl.TipoRegisto",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW0078",
    "originSystem": "FSCD",
    "title": "FSCD BGOW0078 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.FSCD.BGOW0078Contract",
    "description": "BGOW0078 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW0078Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW0078 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1048",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1048."
          },
          {
            "source": null,
            "sourceField": "1051",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1051."
          },
          {
            "source": null,
            "sourceField": "1052",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1052."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-DOCUMENTO / TIPO-IMPRESSAO / USERID / COD-COMPANHIA",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW0078.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0078Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-DOCUMENTO            PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentInformation.CodDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO           PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USERID                   PIC X(08).",
            "sourceField": "USERID",
            "target": "DocumentInformation.Userid",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA            PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA                PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-AUX-MARCA                PIC X(01).",
            "sourceField": "AUX-MARCA",
            "target": "DocumentInformation.AuxMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "DocumentInformation.NrAgente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM               PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-IND-FLYER                PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "DocumentInformation.IndFlyer",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-RAMO / DESCR-RAMO-PROD",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW0078.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0078Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE               PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-COD-RAMO               PIC X(10).",
            "sourceField": "COD-RAMO",
            "target": "Policy.CodRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DESCR-RAMO-PROD        PIC X(40).",
            "sourceField": "DESCR-RAMO-PROD",
            "target": "Policy.DescrRamoProd",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "NR-CLIENTE / CL-NOME / CL-LOCATION-REF / CL-MORADA1",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW0078.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0078Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE               PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NOME                PIC X(40).",
            "sourceField": "CL-NOME",
            "target": "Client.ClNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "Client.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "Client.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "Client.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "Client.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "Client.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "Client.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS               PIC X(03).",
            "sourceField": "CL-CPAIS",
            "target": "Client.ClCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPAIS-DESC          PIC X(40).",
            "sourceField": "CL-CPAIS-DESC",
            "target": "Client.ClCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-IDP                 PIC X(04).",
            "sourceField": "CL-IDP",
            "target": "Client.ClIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-NIF                 PIC X(22).",
            "sourceField": "CL-NIF",
            "target": "Client.ClNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-TIPO-ENTIDADE       PIC X(01).",
            "sourceField": "CL-TIPO-ENTIDADE",
            "target": "Client.ClTipoEntidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DO-NOME-TOMADOR        PIC X(40).",
            "sourceField": "DO-NOME-TOMADOR",
            "target": "Client.DoNomeTomador",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "NR-AGENTE",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW0078.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0078Contract.Agent",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-AGENTE                PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "Agent.NrAgente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "CL-LOCATION-REF / CL-MORADA1 / CL-MORADA2 / CL-LOCALIDADE",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW0078.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0078Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-CL-LOCATION-REF        PIC X(04).",
            "sourceField": "CL-LOCATION-REF",
            "target": "MailingAddress.ClLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA1             PIC X(40).",
            "sourceField": "CL-MORADA1",
            "target": "MailingAddress.ClMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-MORADA2             PIC X(40).",
            "sourceField": "CL-MORADA2",
            "target": "MailingAddress.ClMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-LOCALIDADE          PIC X(40).",
            "sourceField": "CL-LOCALIDADE",
            "target": "MailingAddress.ClLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL             PIC X(09).",
            "sourceField": "CL-CPOSTAL",
            "target": "MailingAddress.ClCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CL-CPOSTAL-DESC        PIC X(40).",
            "sourceField": "CL-CPOSTAL-DESC",
            "target": "MailingAddress.ClCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "PaymentAccount",
        "sourceGroup": "DP-IBAN / DP-SWIFT",
        "targetType": "BankAccount?",
        "targetPath": "PaymentAccount",
        "decision": "mapped",
        "description": "Bank-account payment details identified in BGOW0078.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0078Contract.PaymentAccount",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DP-IBAN                PIC X(34).",
            "sourceField": "DP-IBAN",
            "target": "PaymentAccount.DpIban",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DP-SWIFT               PIC X(11).",
            "sourceField": "DP-SWIFT",
            "target": "PaymentAccount.DpSwift",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "VLR-ILIQUIDO / VLR-BASE-TRIBUTAVEL / VLR-IRS-IRC / VLR-LIQUIDO",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW0078.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0078Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-VLR-ILIQUIDO           PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "VLR-ILIQUIDO",
            "target": "Premium.VlrIliquido",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-BASE-TRIBUTAVEL    PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "VLR-BASE-TRIBUTAVEL",
            "target": "Premium.VlrBaseTributavel",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-IRS-IRC            PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "VLR-IRS-IRC",
            "target": "Premium.VlrIrsIrc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VLR-LIQUIDO            PIC S9(12)V9(02)\n                                   SIGN LEADING SEPARATE.",
            "sourceField": "VLR-LIQUIDO",
            "target": "Premium.VlrLiquido",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "RiskUnit",
        "sourceGroup": "DO-NOME-TOMADOR / DO-DESC-TIPO-SIN",
        "targetType": "RiskUnit",
        "targetPath": "RiskUnit",
        "decision": "mapped",
        "description": "Insured object, insured person, or risk-unit data identified in BGOW0078.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0078Contract.RiskUnit",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DO-NOME-TOMADOR        PIC X(40).",
            "sourceField": "DO-NOME-TOMADOR",
            "target": "RiskUnit.DoNomeTomador",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DO-DESC-TIPO-SIN       PIC X(40).",
            "sourceField": "DO-DESC-TIPO-SIN",
            "target": "RiskUnit.DoDescTipoSin",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DT-EMISSAO / DT-OCORRENCIA / DT-EFEITO",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0078.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0078Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DT-EMISSAO             PIC X(08).",
            "sourceField": "DT-EMISSAO",
            "target": "Tables.DtEmissao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0078."
          },
          {
            "source": "09  :PREFIX:-DT-OCORRENCIA          PIC X(08).",
            "sourceField": "DT-OCORRENCIA",
            "target": "Tables.DtOcorrencia",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0078."
          },
          {
            "source": "09  :PREFIX:-DT-EFEITO              PIC X(08).",
            "sourceField": "DT-EFEITO",
            "target": "Tables.DtEfeito",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0078."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REGISTO",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW0078.",
        "rows": [
          {
            "source": null,
            "target": "BGOW0078Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REGISTO             PIC X(01).",
            "sourceField": "TIPO-REGISTO",
            "target": "PrintRecordControl.TipoRegisto",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW9062",
    "originSystem": "GIS",
    "title": "GIS BGOW9062 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.GIS.BGOW9062Contract",
    "description": "BGOW9062 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW9062Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW9062 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1326",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1326."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-COMPANHIA / COD-MARCA / COD-ORIGEM / NR-MEDIADOR",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA          PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA              PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM             PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-MEDIADOR            PIC X(10).",
            "sourceField": "NR-MEDIADOR",
            "target": "DocumentInformation.NrMediador",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE             PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE             PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-PRODUTO            PIC X(06).",
            "sourceField": "COD-PRODUTO",
            "target": "DocumentInformation.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-DATA-HORA              PIC X(14).",
            "sourceField": "DATA-HORA",
            "target": "DocumentInformation.DataHora",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NUM-DOC                PIC 9(07).",
            "sourceField": "NUM-DOC",
            "target": "DocumentInformation.NumDoc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NUM-REGISTO            PIC 9(07).",
            "sourceField": "NUM-REGISTO",
            "target": "DocumentInformation.NumRegisto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-DOCUMENTO         PIC X(04).",
            "sourceField": "TIPO-DOCUMENTO",
            "target": "DocumentInformation.TipoDocumento",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO         PIC X(03).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-MARCA-REIMPRESSAO      PIC X(01).",
            "sourceField": "MARCA-REIMPRESSAO",
            "target": "DocumentInformation.MarcaReimpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-DOC-ID                 PIC X(03).",
            "sourceField": "DOC-ID",
            "target": "DocumentInformation.DocId",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USER-ID                PIC X(08).",
            "sourceField": "USER-ID",
            "target": "DocumentInformation.UserId",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-PRODUTO / ADERENTE / APOLICE-NCR",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE             PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-PRODUTO            PIC X(06).",
            "sourceField": "COD-PRODUTO",
            "target": "Policy.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-ADERENTE               PIC X(08).",
            "sourceField": "ADERENTE",
            "target": "Policy.Aderente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-APOLICE-NCR            PIC X(08).",
            "sourceField": "APOLICE-NCR",
            "target": "Policy.ApoliceNcr",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DG-PRODUTO-DESC      PIC X(40).",
            "sourceField": "DG-PRODUTO-DESC",
            "target": "Policy.DgProdutoDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DG-COD-RAMO          PIC X(02).",
            "sourceField": "DG-COD-RAMO",
            "target": "Policy.DgCodRamo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CB-MODALIDADE      PIC X(02).",
            "sourceField": "CB-MODALIDADE",
            "target": "Policy.CbModalidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "COD-POSTALC / NR-CLIENTE / TM-NOME / TM-LOCATION-REF",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-POSTALC            PIC X(09).",
            "sourceField": "COD-POSTALC",
            "target": "Client.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE             PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-NOME              PIC X(40).",
            "sourceField": "TM-NOME",
            "target": "Client.TmNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCATION-REF      PIC X(04).",
            "sourceField": "TM-LOCATION-REF",
            "target": "Client.TmLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA1           PIC X(40).",
            "sourceField": "TM-MORADA1",
            "target": "Client.TmMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA2           PIC X(40).",
            "sourceField": "TM-MORADA2",
            "target": "Client.TmMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCALIDADE        PIC X(40).",
            "sourceField": "TM-LOCALIDADE",
            "target": "Client.TmLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL           PIC X(09).",
            "sourceField": "TM-CPOSTAL",
            "target": "Client.TmCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL-DESC      PIC X(40).",
            "sourceField": "TM-CPOSTAL-DESC",
            "target": "Client.TmCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPAIS             PIC X(03).",
            "sourceField": "TM-CPAIS",
            "target": "Client.TmCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPAIS-DESC        PIC X(40).",
            "sourceField": "TM-CPAIS-DESC",
            "target": "Client.TmCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-IDP               PIC X(04).",
            "sourceField": "TM-IDP",
            "target": "Client.TmIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-NIF               PIC X(22).",
            "sourceField": "TM-NIF",
            "target": "Client.TmNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-TIPO-ENTIDADE     PIC X(01).",
            "sourceField": "TM-TIPO-ENTIDADE",
            "target": "Client.TmTipoEntidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Mediator",
        "sourceGroup": "COD-POSTALM / NR-MEDIADOR",
        "targetType": "Entity?",
        "targetPath": "Mediator",
        "decision": "mapped",
        "description": "Optional mediator party identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.Mediator",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-POSTALM            PIC X(09).",
            "sourceField": "COD-POSTALM",
            "target": "Mediator.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-MEDIADOR            PIC X(10).",
            "sourceField": "NR-MEDIADOR",
            "target": "Mediator.NrMediador",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "COD-POSTALM / COD-POSTALC / TM-LOCATION-REF / TM-MORADA1",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-POSTALM            PIC X(09).",
            "sourceField": "COD-POSTALM",
            "target": "MailingAddress.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-POSTALC            PIC X(09).",
            "sourceField": "COD-POSTALC",
            "target": "MailingAddress.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCATION-REF      PIC X(04).",
            "sourceField": "TM-LOCATION-REF",
            "target": "MailingAddress.TmLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA1           PIC X(40).",
            "sourceField": "TM-MORADA1",
            "target": "MailingAddress.TmMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA2           PIC X(40).",
            "sourceField": "TM-MORADA2",
            "target": "MailingAddress.TmMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCALIDADE        PIC X(40).",
            "sourceField": "TM-LOCALIDADE",
            "target": "MailingAddress.TmLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL           PIC X(09).",
            "sourceField": "TM-CPOSTAL",
            "target": "MailingAddress.TmCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL-DESC      PIC X(40).",
            "sourceField": "TM-CPOSTAL-DESC",
            "target": "MailingAddress.TmCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-MORADA            PIC X(40).",
            "sourceField": "PS-MORADA",
            "target": "MailingAddress.PsMorada",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-LOCALIDADE        PIC X(40).",
            "sourceField": "PS-LOCALIDADE",
            "target": "MailingAddress.PsLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-FS-MORADA            PIC X(40).",
            "sourceField": "FS-MORADA",
            "target": "MailingAddress.FsMorada",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-FS-LOCALIDADE        PIC X(40).",
            "sourceField": "FS-LOCALIDADE",
            "target": "MailingAddress.FsLocalidade",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "DG-CAPITAL-SEG / DG-PREMIO-ANUAL / G1-CAPITAL-SEG / G2-CAPITAL-SEG",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DG-CAPITAL-SEG       PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DG-CAPITAL-SEG",
            "target": "Premium.DgCapitalSeg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DG-PREMIO-ANUAL      PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DG-PREMIO-ANUAL",
            "target": "Premium.DgPremioAnual",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-G1-CAPITAL-SEG       PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "G1-CAPITAL-SEG",
            "target": "Premium.G1CapitalSeg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-G2-CAPITAL-SEG       PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "G2-CAPITAL-SEG",
            "target": "Premium.G2CapitalSeg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PR-PREMIO-COM        PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "PR-PREMIO-COM",
            "target": "Premium.PrPremioCom",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PR-PREMIO-TOT        PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "PR-PREMIO-TOT",
            "target": "Premium.PrPremioTot",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PR-CAPITAL-BASE      PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "PR-CAPITAL-BASE",
            "target": "Premium.PrCapitalBase",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-GA-PREMIO-ANUAL    PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "GA-PREMIO-ANUAL",
            "target": "Premium.GaPremioAnual",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-GA-PREMIO-FRAC     PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "GA-PREMIO-FRAC",
            "target": "Premium.GaPremioFrac",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-GA-CAPITAL-SEG     PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "GA-CAPITAL-SEG",
            "target": "Premium.GaCapitalSeg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VR-VALOR-RESG        PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "VR-VALOR-RESG",
            "target": "Premium.VrValorResg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PT-PREMIO            PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "PT-PREMIO",
            "target": "Premium.PtPremio",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "RiskUnit",
        "sourceGroup": "PS-NR-ADESAO / PS-NOME / PS-DT-ADESAO / PS-DT-NASC",
        "targetType": "RiskUnit",
        "targetPath": "RiskUnit",
        "decision": "mapped",
        "description": "Insured object, insured person, or risk-unit data identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.RiskUnit",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-PS-NR-ADESAO         PIC X(05).",
            "sourceField": "PS-NR-ADESAO",
            "target": "RiskUnit.PsNrAdesao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-NOME              PIC X(40).",
            "sourceField": "PS-NOME",
            "target": "RiskUnit.PsNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-DT-ADESAO         PIC X(08).",
            "sourceField": "PS-DT-ADESAO",
            "target": "RiskUnit.PsDtAdesao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-DT-NASC           PIC X(08).",
            "sourceField": "PS-DT-NASC",
            "target": "RiskUnit.PsDtNasc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-MORADA            PIC X(40).",
            "sourceField": "PS-MORADA",
            "target": "RiskUnit.PsMorada",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-LOCALIDADE        PIC X(40).",
            "sourceField": "PS-LOCALIDADE",
            "target": "RiskUnit.PsLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-COD-POST          PIC X(08).",
            "sourceField": "PS-COD-POST",
            "target": "RiskUnit.PsCodPost",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-DESC-CP           PIC X(40).",
            "sourceField": "PS-DESC-CP",
            "target": "RiskUnit.PsDescCp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-PS-CONC-PREST        PIC X(40).",
            "sourceField": "PS-CONC-PREST",
            "target": "RiskUnit.PsConcPrest",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VR-ANO               PIC X(02).",
            "sourceField": "VR-ANO",
            "target": "RiskUnit.VrAno",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VR-COB-DESC          PIC X(60).",
            "sourceField": "VR-COB-DESC",
            "target": "RiskUnit.VrCobDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-VR-VALOR-RESG        PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "VR-VALOR-RESG",
            "target": "RiskUnit.VrValorResg",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Coverages",
        "sourceGroup": "G1-DESC-COB / G2-DESC-COB / GA-DESC-COB / CB-MODALIDADE",
        "targetType": "IReadOnlyList<Coverage>",
        "targetPath": "Coverages",
        "decision": "mapped",
        "description": "Coverage rows identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.Coverages",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-G1-DESC-COB          PIC X(60).",
            "sourceField": "G1-DESC-COB",
            "target": "Coverages.G1DescCob",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-G2-DESC-COB          PIC X(60).",
            "sourceField": "G2-DESC-COB",
            "target": "Coverages.G2DescCob",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-GA-DESC-COB        PIC X(60).",
            "sourceField": "GA-DESC-COB",
            "target": "Coverages.GaDescCob",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CB-MODALIDADE      PIC X(02).",
            "sourceField": "CB-MODALIDADE",
            "target": "Coverages.CbModalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CB-VERSAO          PIC X(02).",
            "sourceField": "CB-VERSAO",
            "target": "Coverages.CbVersao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "11  :PREFIX:-CB-CODIGO          PIC X(10).",
            "sourceField": "CB-CODIGO",
            "target": "Coverages.CbCodigo",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CB-CAPS              PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "CB-CAPS",
            "target": "Coverages.CbCaps",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CB-TAXA              PIC X(06).",
            "sourceField": "CB-TAXA",
            "target": "Coverages.CbTaxa",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CB-VARI              PIC X(77).",
            "sourceField": "CB-VARI",
            "target": "Coverages.CbVari",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "TextBlocks",
        "sourceGroup": "G1-NOTA / G2-NOTA / GN-NOTA / GA-NOTA",
        "targetType": "IReadOnlyList<TextBlock>",
        "targetPath": "TextBlocks",
        "decision": "candidate",
        "description": "Document text, notes, clauses, or message lines identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.TextBlocks",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-G1-NOTA              PIC X(25).",
            "sourceField": "G1-NOTA",
            "target": "TextBlocks.G1Nota",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-G2-NOTA              PIC X(25).",
            "sourceField": "G2-NOTA",
            "target": "TextBlocks.G2Nota",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-GN-NOTA              PIC X(3000).",
            "sourceField": "GN-NOTA",
            "target": "TextBlocks.GnNota",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9062."
          },
          {
            "source": "11  :PREFIX:-GA-NOTA            PIC X(3000).",
            "sourceField": "GA-NOTA",
            "target": "TextBlocks.GaNota",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-EX-TEXT              PIC X(75).",
            "sourceField": "EX-TEXT",
            "target": "TextBlocks.ExText",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9062."
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "G1-DESC-COB / G1-CAPITAL-SEG / G1-NOTA / G2-DESC-COB",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-G1-DESC-COB          PIC X(60).",
            "sourceField": "G1-DESC-COB",
            "target": "Tables.G1DescCob",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-G1-CAPITAL-SEG       PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "G1-CAPITAL-SEG",
            "target": "Tables.G1CapitalSeg",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-G1-NOTA              PIC X(25).",
            "sourceField": "G1-NOTA",
            "target": "Tables.G1Nota",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-G2-DESC-COB          PIC X(60).",
            "sourceField": "G2-DESC-COB",
            "target": "Tables.G2DescCob",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-G2-CAPITAL-SEG       PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "G2-CAPITAL-SEG",
            "target": "Tables.G2CapitalSeg",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-G2-NOTA              PIC X(25).",
            "sourceField": "G2-NOTA",
            "target": "Tables.G2Nota",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "11  :PREFIX:-GA-DESC-COB        PIC X(60).",
            "sourceField": "GA-DESC-COB",
            "target": "Tables.GaDescCob",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "11  :PREFIX:-GA-PREMIO-ANUAL    PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "GA-PREMIO-ANUAL",
            "target": "Tables.GaPremioAnual",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "11  :PREFIX:-GA-PREMIO-FRAC     PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "GA-PREMIO-FRAC",
            "target": "Tables.GaPremioFrac",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "11  :PREFIX:-GA-CAPITAL-SEG     PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "GA-CAPITAL-SEG",
            "target": "Tables.GaCapitalSeg",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "11  :PREFIX:-GA-NOTA            PIC X(3000).",
            "sourceField": "GA-NOTA",
            "target": "Tables.GaNota",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-BE-TIPO              PIC X(10).",
            "sourceField": "BE-TIPO",
            "target": "Tables.BeTipo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-BE-NOME              PIC X(40).",
            "sourceField": "BE-NOME",
            "target": "Tables.BeNome",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-BE-NUMERO            PIC X(04).",
            "sourceField": "BE-NUMERO",
            "target": "Tables.BeNumero",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-FS-NR-ADESAO         PIC X(05).",
            "sourceField": "FS-NR-ADESAO",
            "target": "Tables.FsNrAdesao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-FS-NOME              PIC X(40).",
            "sourceField": "FS-NOME",
            "target": "Tables.FsNome",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-FS-DT-ADESAO         PIC X(08).",
            "sourceField": "FS-DT-ADESAO",
            "target": "Tables.FsDtAdesao",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          },
          {
            "source": "09  :PREFIX:-FS-DT-NASC           PIC X(08).",
            "sourceField": "FS-DT-NASC",
            "target": "Tables.FsDtNasc",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9062."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "NUM-DOC / NUM-REGISTO / TIPO-REG / DOC-ID",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW9062.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9062Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NUM-DOC                PIC 9(07).",
            "sourceField": "NUM-DOC",
            "target": "PrintRecordControl.NumDoc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NUM-REGISTO            PIC 9(07).",
            "sourceField": "NUM-REGISTO",
            "target": "PrintRecordControl.NumRegisto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-REG               PIC X(04).",
            "sourceField": "TIPO-REG",
            "target": "PrintRecordControl.TipoReg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-DOC-ID                 PIC X(03).",
            "sourceField": "DOC-ID",
            "target": "PrintRecordControl.DocId",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW9064",
    "originSystem": "COGEN22",
    "title": "Tailor aggregate plan particular conditions",
    "contractType": "Outputs.Documents.Domain.Contracts.COGEN22.BGOW9064Contract",
    "description": "BGOW9064 keeps the copybook flow as the source of truth. Reusable groups are promoted into typed document, address, entity, policy, risk, coverage, and document text objects while unresolved legacy fields remain raw and searchable.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW9064Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "The document identification is not part of the copybook payload. It is the template/document selector used by the rendering layer.",
        "rows": [
          {
            "source": null,
            "sourceField": "1327",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1327."
          }
        ]
      },
      {
        "title": "Registration and routing header",
        "sourceGroup": "DADOS-REGISTO",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "This level identifies how the document was requested, who created it, and where it came from. It migrates into document metadata because these fields describe the document envelope and routing context, not the client or policy body.",
        "rows": [
          {
            "source": "05 :PREFIX:-DADOS-REGISTO.",
            "target": "BGOW9064Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07 :PREFIX:-COD-DOCUMENTO PIC X(04).",
            "sourceField": "COD-DOCUMENTO",
            "target": "DocumentCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TIPO-REGISTO PIC X(04).",
            "sourceField": "TIPO-REGISTO",
            "target": "TipoRegisto raw contract field",
            "status": "raw",
            "reason": "Legacy record discriminator kept raw."
          },
          {
            "source": "07 :PREFIX:-TIPO-IMPRESSAO PIC X(01).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "PrintType",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-USERID PIC X(08).",
            "sourceField": "USERID",
            "target": "UserId",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-COD-COMPANHIA PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "CompanyCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-COD-MARCA PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "BrandCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-NR-AGENTE PIC X(10).",
            "sourceField": "NR-AGENTE",
            "target": "AgentNumber",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-NR-CLIENTE PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "ClientNumber",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-NR-APOLICE PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "PolicyNumber",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DOC-NR PIC X(10).",
            "sourceField": "DOC-NR",
            "target": "OriginDocumentNumber",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DOC-SEQREG-NR PIC X(05).",
            "sourceField": "DOC-SEQREG-NR",
            "target": "OriginSequenceNumber",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-COD-ORIGEM PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "OriginSystemCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-IND-FLYER PIC X(01).",
            "sourceField": "IND-FLYER",
            "target": "FlyerIndicator",
            "status": "mapped"
          },
          {
            "source": null,
            "target": "DocumentTypeCode",
            "status": "target-only",
            "reason": "Reusable field supported by DocumentInformation but not populated by BGOW9064."
          },
          {
            "source": null,
            "target": "PolicyTransactionCode",
            "status": "target-only",
            "reason": "Reusable field supported by DocumentInformation but not populated by BGOW9064."
          },
          {
            "source": null,
            "target": "ProductCode",
            "status": "target-only",
            "reason": "Reusable field supported by DocumentInformation but not populated by BGOW9064."
          },
          {
            "source": null,
            "target": "ProcessingDate",
            "status": "target-only",
            "reason": "Reusable field supported by DocumentInformation but not populated by BGOW9064."
          }
        ]
      },
      {
        "title": "Postal destination",
        "sourceGroup": "DADOS-MORADA",
        "targetType": "PostalAddress",
        "targetPath": "PostalAddress",
        "decision": "mapped",
        "description": "This level is a postal destination. It is promoted into the common address object so clients, agents, creditors, and mailing blocks use the same address vocabulary across copybooks.",
        "rows": [
          {
            "source": "05 :PREFIX:-DADOS-DOCUMENTO PIC X(421).",
            "sourceField": "DADOS-DOCUMENTO",
            "target": "DadosDocumento raw payload area",
            "status": "raw",
            "reason": "Envelope/redefines area retained for traceability."
          },
          {
            "source": "07 :PREFIX:-DADOS-MORADA.",
            "target": "BGOW9064Contract.PostalAddress",
            "status": "container"
          },
          {
            "source": "09 :PREFIX:-MR-NOME PIC X(40).",
            "sourceField": "MR-NOME",
            "target": "Name",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-MR-LOCATION-REF PIC X(04).",
            "sourceField": "MR-LOCATION-REF",
            "target": "Reference",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-MR-MORADA1 PIC X(40).",
            "sourceField": "MR-MORADA1",
            "target": "Line1",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-MR-MORADA2 PIC X(40).",
            "sourceField": "MR-MORADA2",
            "target": "Line2",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-MR-LOCALIDADE PIC X(40).",
            "sourceField": "MR-LOCALIDADE",
            "target": "Locality",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-MR-CPOSTAL PIC X(09).",
            "sourceField": "MR-CPOSTAL",
            "target": "PostalCode",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-MR-CPOSTAL-DESC PIC X(40).",
            "sourceField": "MR-CPOSTAL-DESC",
            "target": "PostalCodeDescription",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-MR-CPAIS PIC X(03).",
            "sourceField": "MR-CPAIS",
            "target": "CountryCode",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-MR-CPAIS-DESC PIC X(40).",
            "sourceField": "MR-CPAIS-DESC",
            "target": "CountryDescription",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-MR-IDP PIC X(04).",
            "sourceField": "MR-IDP",
            "target": "DoorIdentifier",
            "status": "mapped"
          },
          {
            "source": null,
            "target": "Line3",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Line4",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "DoorTypeCode",
            "status": "target-only"
          }
        ]
      },
      {
        "title": "Client identity",
        "sourceGroup": "DADOS-CLIENTE",
        "targetType": "Entity",
        "targetPath": "Entity",
        "decision": "mapped",
        "description": "The copybook calls this group client data. The shared domain type is Entity because the same identity shape appears later as clients, mediators, creditors, and other document parties.",
        "rows": [
          {
            "source": "07 :PREFIX:-DADOS-CLIENTE.",
            "target": "BGOW9064Contract.Entity",
            "status": "container"
          },
          {
            "source": "09 :PREFIX:-CL-NOME PIC X(40).",
            "sourceField": "CL-NOME",
            "target": "Name",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-CL-NIF PIC X(22).",
            "sourceField": "CL-NIF",
            "target": "TaxIdentificationNumber",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-CL-TIPO-ENTIDADE PIC X(01).",
            "sourceField": "CL-TIPO-ENTIDADE",
            "target": "TypeCode and Type",
            "status": "mapped"
          },
          {
            "source": null,
            "target": "Reference",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Number",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Address",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Contact",
            "status": "target-only"
          }
        ]
      },
      {
        "title": "General policy/product context",
        "sourceGroup": "DADOS-GERAIS",
        "targetType": "Raw contract fields, candidate Policy model",
        "targetPath": "BGOW9064Contract raw fields",
        "targetLabel": "Current decision",
        "decision": "candidate",
        "description": "This level is policy and product context, but it has not yet been promoted to a final shared object for BGOW9064. The fields stay raw and annotated until another copybook confirms the same shape and naming.",
        "rows": [
          {
            "source": "07 :PREFIX:-DADOS-GERAIS.",
            "target": "BGOW9064Contract raw fields",
            "status": "container"
          },
          {
            "source": "09 :PREFIX:-DG-DT-EMISSAO PIC X(08).",
            "sourceField": "DG-DT-EMISSAO",
            "target": "DgDtEmissao",
            "status": "candidate"
          },
          {
            "source": "09 :PREFIX:-DG-PRODUTO-DESC PIC X(40).",
            "sourceField": "DG-PRODUTO-DESC",
            "target": "DgProdutoDesc",
            "status": "candidate"
          },
          {
            "source": "09 :PREFIX:-DG-COD-RAMO PIC X(02).",
            "sourceField": "DG-COD-RAMO",
            "target": "DgCodRamo",
            "status": "candidate"
          },
          {
            "source": "09 :PREFIX:-DG-DT-VENCIMENTO PIC X(08).",
            "sourceField": "DG-DT-VENCIMENTO",
            "target": "DgDtVencimento",
            "status": "candidate"
          },
          {
            "source": "09 :PREFIX:-DG-DT-INI-PERIODO PIC X(08).",
            "sourceField": "DG-DT-INI-PERIODO",
            "target": "DgDtIniPeriodo",
            "status": "candidate"
          },
          {
            "source": "09 :PREFIX:-DG-DT-FIM-PERIODO PIC X(08).",
            "sourceField": "DG-DT-FIM-PERIODO",
            "target": "DgDtFimPeriodo",
            "status": "candidate"
          },
          {
            "source": "09 :PREFIX:-DG-TIPO-FRACCIONA PIC X(01).",
            "sourceField": "DG-TIPO-FRACCIONA",
            "target": "DgTipoFracciona",
            "status": "candidate"
          },
          {
            "source": "09 :PREFIX:-DG-TIPO-TRANSACAO PIC X(01).",
            "sourceField": "DG-TIPO-TRANSACAO",
            "target": "DgTipoTransacao",
            "status": "candidate"
          }
        ]
      },
      {
        "title": "Premium values",
        "sourceGroup": "DADOS-VALOR",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "The copybook already groups these monetary fields as premium data. The group is kept together and moved under the policy domain because premium values only make sense in the context of an insurance policy.",
        "rows": [
          {
            "source": "07 :PREFIX:-DADOS-VALOR.",
            "target": "BGOW9064Contract.Premium",
            "status": "container"
          },
          {
            "source": "09 :PREFIX:-DV-PREMIO-COM PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-PREMIO-COM",
            "target": "Commercial",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-ENCARGOS PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-ENCARGOS",
            "target": "Charges",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-PREMIO-TOT PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-PREMIO-TOT",
            "target": "Total",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-PREMIO-COM-AD PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-PREMIO-COM-AD",
            "target": "AdditionalCommercial",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-ENCARGOS-AD PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-ENCARGOS-AD",
            "target": "AdditionalCharges",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-PREMIO-TOT-AD PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-PREMIO-TOT-AD",
            "target": "AdditionalTotal",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-PREMIO-COM-1F PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-PREMIO-COM-1F",
            "target": "FirstFractionCommercial",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-ENCARGOS-1F PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-ENCARGOS-1F",
            "target": "FirstFractionCharges",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-PREMIO-TOT-1F PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-PREMIO-TOT-1F",
            "target": "FirstFractionTotal",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-PREMIO-COM-FS PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-PREMIO-COM-FS",
            "target": "FollowingFractionsCommercial",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-ENCARGOS-FS PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-ENCARGOS-FS",
            "target": "FollowingFractionsCharges",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DV-PREMIO-TOT-FS PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "DV-PREMIO-TOT-FS",
            "target": "FollowingFractionsTotal",
            "status": "mapped"
          }
        ]
      },
      {
        "title": "Insured object and risk detail",
        "sourceGroup": "OBJECTO-SEGURO / DET-OBJ-SEG",
        "targetType": "RiskUnit",
        "targetPath": "RiskUnit",
        "decision": "mapped",
        "description": "These groups describe what is insured and the risk context around it. Shared fields move into RiskUnit. Specific details that do not yet have a stable common meaning remain raw, while RiskUnit exposes typed detail slots for future copybooks.",
        "rows": [
          {
            "source": "07 :PREFIX:-OBJECTO-SEGURO.",
            "target": "BGOW9064Contract.RiskUnit",
            "status": "container"
          },
          {
            "source": "09 :PREFIX:-OS-OBJECTO-SEG PIC X(20).",
            "sourceField": "OS-OBJECTO-SEG",
            "target": "Description",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-OS-LOCAL-RISC1 PIC X(40).",
            "sourceField": "OS-LOCAL-RISC1",
            "target": "RiskLocationLine1",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-OS-LOCAL-RISC2 PIC X(40).",
            "sourceField": "OS-LOCAL-RISC2",
            "target": "RiskLocationLine2",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-OS-CAPITAL-SEG PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "OS-CAPITAL-SEG",
            "target": "InsuredCapital",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-PR-PRODUTO PIC X(60).",
            "sourceField": "PR-PRODUTO",
            "target": "ProductDescription",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DO-PRODUTO PIC X(60).",
            "sourceField": "DO-PRODUTO",
            "target": "ProductDescription",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DO-APOLICE PIC X(16).",
            "sourceField": "DO-APOLICE",
            "target": "PolicyNumber",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DO-OBJETO-SEG PIC X(40).",
            "sourceField": "DO-OBJETO-SEG",
            "target": "Description",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DO-ACTIVIDADE PIC X(60).",
            "sourceField": "DO-ACTIVIDADE",
            "target": "ActivityDescription",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DO-MODALIDADE PIC X(30).",
            "sourceField": "DO-MODALIDADE",
            "target": "ModalityDescription",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DO-AMBITO-COB PIC X(50).",
            "sourceField": "DO-AMBITO-COB",
            "target": "CoverageScopeDescription",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DO-LOCAL-RISC PIC X(200).",
            "sourceField": "DO-LOCAL-RISC",
            "target": "RiskLocationDescription",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DO-NR-TRABALH PIC X(05).",
            "sourceField": "DO-NR-TRABALH",
            "target": "WorkerCount",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-LT-NOME PIC X(40).",
            "sourceField": "LT-NOME",
            "target": "LtNome raw contract field",
            "status": "raw"
          },
          {
            "source": "09 :PREFIX:-LT-PROFISSAO PIC X(20).",
            "sourceField": "LT-PROFISSAO",
            "target": "LtProfissao raw contract field",
            "status": "raw"
          },
          {
            "source": "09 :PREFIX:-LT-RETR-ANUAL PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "LT-RETR-ANUAL",
            "target": "LtRetrAnual raw contract field",
            "status": "raw"
          },
          {
            "source": "09 :PREFIX:-LT-DET-RETR PIC X(75).",
            "sourceField": "LT-DET-RETR",
            "target": "LtDetRetr raw contract field",
            "status": "raw"
          },
          {
            "source": "09 :PREFIX:-RU-DESCRITIVO PIC X(60).",
            "sourceField": "RU-DESCRITIVO",
            "target": "RuDescritivo raw contract field",
            "status": "raw"
          },
          {
            "source": "09 :PREFIX:-RU-VALOR PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "RU-VALOR",
            "target": "RuValor raw contract field",
            "status": "raw"
          },
          {
            "source": null,
            "target": "Count",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Type",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "General / LifeRisk / Health / Vehicle / Garage / OtherVehicle / MultiRisk / WorkAccident",
            "status": "target-only"
          }
        ]
      },
      {
        "title": "Coverage rows",
        "sourceGroup": "COBERTURAS",
        "targetType": "Coverage[]",
        "targetPath": "Coverages",
        "decision": "mapped",
        "description": "COBERTURAS is a repeated group. The coverage identity and description fields go to Coverage, while franchise and indemnity-limit fields are grouped under CoverageDeductible.",
        "rows": [
          {
            "source": "07 :PREFIX:-COBERTURAS OCCURS.",
            "target": "BGOW9064Contract.Coverages[]",
            "status": "container"
          },
          {
            "source": "09 :PREFIX:-CB-TIPO-COBERTURA PIC X(03).",
            "sourceField": "CB-TIPO-COBERTURA",
            "target": "Coverage.TypeCode",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-CB-COD-COB PIC X(05).",
            "sourceField": "CB-COD-COB",
            "target": "Coverage.Code",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-CB-DESC-COB PIC X(60).",
            "sourceField": "CB-DESC-COB",
            "target": "Coverage.Description",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-CB-TIPO-TABELA PIC X(02).",
            "sourceField": "CB-TIPO-TABELA",
            "target": "Coverage.TableType",
            "status": "mapped"
          },
          {
            "source": "11 :PREFIX:-CB-COD-FRANQUIA PIC X(02).",
            "sourceField": "CB-COD-FRANQUIA",
            "target": "Coverage.Deductible.TypeCode",
            "status": "mapped"
          },
          {
            "source": "11 :PREFIX:-CB-VALOR-FRANQUIA PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "CB-VALOR-FRANQUIA",
            "target": "Coverage.Deductible.Value",
            "status": "mapped"
          },
          {
            "source": "11 :PREFIX:-CB-VALOR-MAX-FRANQ PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "CB-VALOR-MAX-FRANQ",
            "target": "Coverage.Deductible.MaximumValue",
            "status": "mapped"
          },
          {
            "source": "11 :PREFIX:-CB-PERC-FRANQUIA PIC 9(03)V9(02).",
            "sourceField": "CB-PERC-FRANQUIA",
            "target": "Coverage.Deductible.Percentage",
            "status": "mapped"
          },
          {
            "source": "11 :PREFIX:-CB-NUMERO-DIAS PIC 9(03).",
            "sourceField": "CB-NUMERO-DIAS",
            "target": "Coverage.Deductible.Days",
            "status": "mapped"
          },
          {
            "source": "11 :PREFIX:-CB-IND-LIM-INDMN PIC X(02).",
            "sourceField": "CB-IND-LIM-INDMN",
            "target": "Coverage.Deductible.IndemnityLimitTypeCode",
            "status": "mapped"
          },
          {
            "source": "11 :PREFIX:-CB-VALOR-LIM-INDMN PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "CB-VALOR-LIM-INDMN",
            "target": "Coverage.Deductible.IndemnityLimitValue",
            "status": "mapped"
          },
          {
            "source": "11 :PREFIX:-CB-PERC-LIM-INDMN PIC 9(02).",
            "sourceField": "CB-PERC-LIM-INDMN",
            "target": "Coverage.Deductible.IndemnityLimitPercentage",
            "status": "mapped"
          },
          {
            "source": "11 :PREFIX:-CB-DIAS-LIM-INDMN PIC 9(02).",
            "sourceField": "CB-DIAS-LIM-INDMN",
            "target": "Coverage.Deductible.IndemnityLimitDays",
            "status": "mapped"
          },
          {
            "source": "11 :PREFIX:-CB-VLR1-LIM-INDMN PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "CB-VLR1-LIM-INDMN",
            "target": "Coverage.Deductible.AnnualIndemnityLimitValue",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-CB-FRANQUIA-CHAR PIC X(30).",
            "sourceField": "CB-FRANQUIA-CHAR",
            "target": "Coverage.DeductibleText",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-CB-VALOR-CAP-SEG PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "CB-VALOR-CAP-SEG",
            "target": "Coverage.InsuredCapital",
            "status": "mapped"
          }
        ]
      },
      {
        "title": "Reusable text/list blocks",
        "sourceGroup": "NOTAS-COBERTURA / COND-GERAIS / DECLAR-CLAUSULAS",
        "targetType": "Document primitives",
        "targetPath": "CoverageNotes / GeneralConditions / ParticularClauses",
        "decision": "mapped",
        "description": "These repeated groups are document content, not insurance entities. They map to small text primitives so templates can render notes, conditions, and clauses without each copybook inventing a new text shape.",
        "rows": [
          {
            "source": "09 :PREFIX:-NC-NOTAS-COB PIC X(80).",
            "sourceField": "NC-NOTAS-COB",
            "target": "CoverageNotes[].Text",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-CG-CODIGO PIC X(03).",
            "sourceField": "CG-CODIGO",
            "target": "GeneralConditions[].Title",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-CG-DESCRITIVO PIC X(80).",
            "sourceField": "CG-DESCRITIVO",
            "target": "GeneralConditions[].Text",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DC-TIPO-DEC-CLAUS PIC X(03).",
            "sourceField": "DC-TIPO-DEC-CLAUS",
            "target": "ParticularClauses[].Title or Subtitle",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-DC-DESCRITIVO PIC X(418).",
            "sourceField": "DC-DESCRITIVO",
            "target": "ParticularClauses[].Text",
            "status": "mapped"
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW9067",
    "originSystem": "GIS",
    "title": "GIS BGOW9067 structural migration",
    "contractType": "Outputs.Documents.Domain.Contracts.GIS.BGOW9067Contract",
    "description": "BGOW9067 was analyzed from the copybook level tree. Reusable groups are projected into shared structures where stable; unresolved fields remain on the raw contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW9067Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "Document identification values owned by BGOW9067 select concrete templates.",
        "rows": [
          {
            "source": null,
            "sourceField": "1244",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1244."
          }
        ]
      },
      {
        "title": "DocumentInformation",
        "sourceGroup": "COD-COMPANHIA / COD-MARCA / COD-ORIGEM / NR-MEDIADOR",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "Structured document envelope and routing information identified in BGOW9067.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9067Contract.DocumentInformation",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-COMPANHIA          PIC X(03).",
            "sourceField": "COD-COMPANHIA",
            "target": "DocumentInformation.CodCompanhia",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-MARCA              PIC X(03).",
            "sourceField": "COD-MARCA",
            "target": "DocumentInformation.CodMarca",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-ORIGEM             PIC X(03).",
            "sourceField": "COD-ORIGEM",
            "target": "DocumentInformation.CodOrigem",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-MEDIADOR            PIC X(10).",
            "sourceField": "NR-MEDIADOR",
            "target": "DocumentInformation.NrMediador",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE             PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "DocumentInformation.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE             PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "DocumentInformation.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-PRODUTO            PIC X(06).",
            "sourceField": "COD-PRODUTO",
            "target": "DocumentInformation.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-DATA-HORA              PIC X(14).",
            "sourceField": "DATA-HORA",
            "target": "DocumentInformation.DataHora",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-TIPO-IMPRESSAO         PIC X(03).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "DocumentInformation.TipoImpressao",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-DOC-ID                 PIC X(03).",
            "sourceField": "DOC-ID",
            "target": "DocumentInformation.DocId",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-USER-ID                PIC X(08).",
            "sourceField": "USER-ID",
            "target": "DocumentInformation.UserId",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Policy",
        "sourceGroup": "NR-APOLICE / COD-PRODUTO / ADERENTE / CR-APOLICE",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "Structured policy, product, branch, certificate, or adherent context identified in BGOW9067.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9067Contract.Policy",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-NR-APOLICE             PIC X(16).",
            "sourceField": "NR-APOLICE",
            "target": "Policy.NrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-PRODUTO            PIC X(06).",
            "sourceField": "COD-PRODUTO",
            "target": "Policy.CodProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-ADERENTE               PIC X(08).",
            "sourceField": "ADERENTE",
            "target": "Policy.Aderente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-CR-APOLICE           PIC X(16).",
            "sourceField": "CR-APOLICE",
            "target": "Policy.CrApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-QR-POU-TIT-PRODUTO   PIC X(30).",
            "sourceField": "QR-POU-TIT-PRODUTO",
            "target": "Policy.QrPouTitProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-QR-POU-TIT-APOLICE   PIC X(20).",
            "sourceField": "QR-POU-TIT-APOLICE",
            "target": "Policy.QrPouTitApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-QR-REF-TIT-PRODUTO   PIC X(30).",
            "sourceField": "QR-REF-TIT-PRODUTO",
            "target": "Policy.QrRefTitProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-QR-REF-TIT-APOLICE   PIC X(20).",
            "sourceField": "QR-REF-TIT-APOLICE",
            "target": "Policy.QrRefTitApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-QD-APO-TIT-PRODUTO   PIC X(30).",
            "sourceField": "QD-APO-TIT-PRODUTO",
            "target": "Policy.QdApoTitProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-QD-APO-TIT-APOLICE   PIC X(20).",
            "sourceField": "QD-APO-TIT-APOLICE",
            "target": "Policy.QdApoTitApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-QT-REN-PRODUTO       PIC X(30).",
            "sourceField": "QT-REN-PRODUTO",
            "target": "Policy.QtRenProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-QT-ANU-PRODUTO       PIC X(30).",
            "sourceField": "QT-ANU-PRODUTO",
            "target": "Policy.QtAnuProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-PRODUTO           PIC X(30).",
            "sourceField": "AG-PRODUTO",
            "target": "Policy.AgProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-APOLICE           PIC X(16).",
            "sourceField": "AG-APOLICE",
            "target": "Policy.AgApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-II-APOLICE           PIC X(16).",
            "sourceField": "II-APOLICE",
            "target": "Policy.IiApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-II-PRODUTO           PIC X(30).",
            "sourceField": "II-PRODUTO",
            "target": "Policy.IiProduto",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Client",
        "sourceGroup": "COD-POSTALC / NR-CLIENTE / TM-NOME / TM-LOCATION-REF",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "Structured client, policyholder, or destination party identified in BGOW9067.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9067Contract.Client",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-POSTALC            PIC X(09).",
            "sourceField": "COD-POSTALC",
            "target": "Client.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-CLIENTE             PIC X(10).",
            "sourceField": "NR-CLIENTE",
            "target": "Client.NrCliente",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-NOME              PIC X(40).",
            "sourceField": "TM-NOME",
            "target": "Client.TmNome",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCATION-REF      PIC X(04).",
            "sourceField": "TM-LOCATION-REF",
            "target": "Client.TmLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA1           PIC X(40).",
            "sourceField": "TM-MORADA1",
            "target": "Client.TmMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA2           PIC X(40).",
            "sourceField": "TM-MORADA2",
            "target": "Client.TmMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCALIDADE        PIC X(40).",
            "sourceField": "TM-LOCALIDADE",
            "target": "Client.TmLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL           PIC X(09).",
            "sourceField": "TM-CPOSTAL",
            "target": "Client.TmCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL-DESC      PIC X(40).",
            "sourceField": "TM-CPOSTAL-DESC",
            "target": "Client.TmCpostalDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPAIS             PIC X(03).",
            "sourceField": "TM-CPAIS",
            "target": "Client.TmCpais",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPAIS-DESC        PIC X(40).",
            "sourceField": "TM-CPAIS-DESC",
            "target": "Client.TmCpaisDesc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-IDP               PIC X(04).",
            "sourceField": "TM-IDP",
            "target": "Client.TmIdp",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-NIF               PIC X(22).",
            "sourceField": "TM-NIF",
            "target": "Client.TmNif",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-TIPO-ENTIDADE     PIC X(01).",
            "sourceField": "TM-TIPO-ENTIDADE",
            "target": "Client.TmTipoEntidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-DG-NOME-CLIENTE      PIC X(40).",
            "sourceField": "DG-NOME-CLIENTE",
            "target": "Client.DgNomeCliente",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Mediator",
        "sourceGroup": "COD-POSTALM / NR-MEDIADOR",
        "targetType": "Entity?",
        "targetPath": "Mediator",
        "decision": "mapped",
        "description": "Optional mediator party identified in BGOW9067.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9067Contract.Mediator",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-POSTALM            PIC X(09).",
            "sourceField": "COD-POSTALM",
            "target": "Mediator.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-NR-MEDIADOR            PIC X(10).",
            "sourceField": "NR-MEDIADOR",
            "target": "Mediator.NrMediador",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Agent",
        "sourceGroup": "AG-PRODUTO / AG-APOLICE / AG-DATA",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "Optional agent or collecting mediator party identified in BGOW9067.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9067Contract.Agent",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-AG-PRODUTO           PIC X(30).",
            "sourceField": "AG-PRODUTO",
            "target": "Agent.AgProduto",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-APOLICE           PIC X(16).",
            "sourceField": "AG-APOLICE",
            "target": "Agent.AgApolice",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-AG-DATA              PIC X(08).",
            "sourceField": "AG-DATA",
            "target": "Agent.AgData",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "MailingAddress",
        "sourceGroup": "COD-POSTALM / COD-POSTALC / TM-LOCATION-REF / TM-MORADA1",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "Structured postal destination or mailing address identified in BGOW9067.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9067Contract.MailingAddress",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-COD-POSTALM            PIC X(09).",
            "sourceField": "COD-POSTALM",
            "target": "MailingAddress.CodPostalm",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-COD-POSTALC            PIC X(09).",
            "sourceField": "COD-POSTALC",
            "target": "MailingAddress.CodPostalc",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCATION-REF      PIC X(04).",
            "sourceField": "TM-LOCATION-REF",
            "target": "MailingAddress.TmLocationRef",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA1           PIC X(40).",
            "sourceField": "TM-MORADA1",
            "target": "MailingAddress.TmMorada1",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-MORADA2           PIC X(40).",
            "sourceField": "TM-MORADA2",
            "target": "MailingAddress.TmMorada2",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-LOCALIDADE        PIC X(40).",
            "sourceField": "TM-LOCALIDADE",
            "target": "MailingAddress.TmLocalidade",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL           PIC X(09).",
            "sourceField": "TM-CPOSTAL",
            "target": "MailingAddress.TmCpostal",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-TM-CPOSTAL-DESC      PIC X(40).",
            "sourceField": "TM-CPOSTAL-DESC",
            "target": "MailingAddress.TmCpostalDesc",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "Premium",
        "sourceGroup": "CR-VL-CAPITAL / II-CAPITAL-GAR",
        "targetType": "Premium",
        "targetPath": "Premium",
        "decision": "mapped",
        "description": "Premium, value, capital, or total amounts identified in BGOW9067.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9067Contract.Premium",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-CR-VL-CAPITAL        PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "CR-VL-CAPITAL",
            "target": "Premium.CrVlCapital",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "09  :PREFIX:-II-CAPITAL-GAR       PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "II-CAPITAL-GAR",
            "target": "Premium.IiCapitalGar",
            "status": "mapped",
            "reason": null
          }
        ]
      },
      {
        "title": "TextBlocks",
        "sourceGroup": "QD-APO-NOT-NOTAS / QT-ANU-DESCRITIVO / IL-TEXT-LIVRE-BOLD / IL-TEXT-LIVRE-NORMAL",
        "targetType": "IReadOnlyList<TextBlock>",
        "targetPath": "TextBlocks",
        "decision": "candidate",
        "description": "Document text, notes, clauses, or message lines identified in BGOW9067.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9067Contract.TextBlocks",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-QD-APO-NOT-NOTAS     PIC X(1000).",
            "sourceField": "QD-APO-NOT-NOTAS",
            "target": "TextBlocks.QdApoNotNotas",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-QT-ANU-DESCRITIVO    PIC X(30).",
            "sourceField": "QT-ANU-DESCRITIVO",
            "target": "TextBlocks.QtAnuDescritivo",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-IL-TEXT-LIVRE-BOLD   PIC X(400).",
            "sourceField": "IL-TEXT-LIVRE-BOLD",
            "target": "TextBlocks.IlTextLivreBold",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-IL-TEXT-LIVRE-NORMAL PIC X(3000).",
            "sourceField": "IL-TEXT-LIVRE-NORMAL",
            "target": "TextBlocks.IlTextLivreNormal",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-II-TEXT-LIVRE-BOLD   PIC X(400).",
            "sourceField": "II-TEXT-LIVRE-BOLD",
            "target": "TextBlocks.IiTextLivreBold",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-II-TEXT-LIVRE-NORMAL PIC X(3000).",
            "sourceField": "II-TEXT-LIVRE-NORMAL",
            "target": "TextBlocks.IiTextLivreNormal",
            "status": "candidate",
            "reason": "Document text, notes, clauses, or message lines identified in BGOW9067."
          }
        ]
      },
      {
        "title": "Tables",
        "sourceGroup": "DG-NR-EXTRATO / SI-DT-INICIO / SI-DT-FINAL / SI-DESC-POUPANCA",
        "targetType": "IReadOnlyList<GenericTable>",
        "targetPath": "Tables",
        "decision": "candidate",
        "description": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9067Contract.Tables",
            "status": "container"
          },
          {
            "source": "09  :PREFIX:-DG-NR-EXTRATO        PIC X(10).",
            "sourceField": "DG-NR-EXTRATO",
            "target": "Tables.DgNrExtrato",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-SI-DT-INICIO         PIC X(08).",
            "sourceField": "SI-DT-INICIO",
            "target": "Tables.SiDtInicio",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-SI-DT-FINAL          PIC X(08).",
            "sourceField": "SI-DT-FINAL",
            "target": "Tables.SiDtFinal",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-SI-DESC-POUPANCA     PIC X(30).",
            "sourceField": "SI-DESC-POUPANCA",
            "target": "Tables.SiDescPoupanca",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-SI-VL-INICIAL-P      PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "SI-VL-INICIAL-P",
            "target": "Tables.SiVlInicialP",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-SI-VL-FINAL-P        PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "SI-VL-FINAL-P",
            "target": "Tables.SiVlFinalP",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-SI-DESC-REFORMA      PIC X(30).",
            "sourceField": "SI-DESC-REFORMA",
            "target": "Tables.SiDescReforma",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-SI-VL-INICIAL-R      PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "SI-VL-INICIAL-R",
            "target": "Tables.SiVlInicialR",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-SI-VL-FINAL-R        PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "SI-VL-FINAL-R",
            "target": "Tables.SiVlFinalR",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-SI-VL-INICIAL-T      PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "SI-VL-INICIAL-T",
            "target": "Tables.SiVlInicialT",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-SI-VL-FINAL-T        PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "SI-VL-FINAL-T",
            "target": "Tables.SiVlFinalT",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-CR-NR-CONTRATOS      PIC 9(03).",
            "sourceField": "CR-NR-CONTRATOS",
            "target": "Tables.CrNrContratos",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-CR-APOLICE           PIC X(16).",
            "sourceField": "CR-APOLICE",
            "target": "Tables.CrApolice",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-CR-DT-TERMINO        PIC X(08).",
            "sourceField": "CR-DT-TERMINO",
            "target": "Tables.CrDtTermino",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-CR-VL-CAPITAL        PIC S9(12)V9(02) SIGN LEADING SEPARATE.",
            "sourceField": "CR-VL-CAPITAL",
            "target": "Tables.CrVlCapital",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-QR-POU-HDR-DT-INICIO PIC X(08).",
            "sourceField": "QR-POU-HDR-DT-INICIO",
            "target": "Tables.QrPouHdrDtInicio",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-QR-POU-HDR-DT-TERMO  PIC X(08).",
            "sourceField": "QR-POU-HDR-DT-TERMO",
            "target": "Tables.QrPouHdrDtTermo",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          },
          {
            "source": "09  :PREFIX:-QR-POU-TIT-PRODUTO   PIC X(30).",
            "sourceField": "QR-POU-TIT-PRODUTO",
            "target": "Tables.QrPouTitProduto",
            "status": "candidate",
            "reason": "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW9067."
          }
        ]
      },
      {
        "title": "PrintRecordControl",
        "sourceGroup": "TIPO-REG / DOC-ID",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "Record type, document sequence, or print-payload control fields identified in BGOW9067.",
        "rows": [
          {
            "source": null,
            "target": "BGOW9067Contract.PrintRecordControl",
            "status": "container"
          },
          {
            "source": "07  :PREFIX:-TIPO-REG               PIC X(04).",
            "sourceField": "TIPO-REG",
            "target": "PrintRecordControl.TipoReg",
            "status": "mapped",
            "reason": null
          },
          {
            "source": "07  :PREFIX:-DOC-ID                 PIC X(03).",
            "sourceField": "DOC-ID",
            "target": "PrintRecordControl.DocId",
            "status": "mapped",
            "reason": null
          }
        ]
      }
    ]
  },
  {
    "copybook": "BGOW9068",
    "originSystem": "COGEN22",
    "title": "Contact and email change letter",
    "contractType": "Outputs.Documents.Domain.Contracts.COGEN22.BGOW9068Contract",
    "description": "BGOW9068 is split into document envelope, client and mediator entities, mailing address, policy/product context, and print payload control. The map keeps all source fields visible and shows where each one lands in the current domain contract.",
    "mappings": [
      {
        "title": "Document selector",
        "sourceGroup": "Document selector",
        "targetType": "BGOW9068Contract",
        "targetPath": "DocumentIdentification",
        "targetLabel": ".NET contract",
        "decision": "selector",
        "description": "The document identification is not part of the copybook payload. It is the template/document selector used by the rendering layer.",
        "rows": [
          {
            "source": null,
            "sourceField": "1328",
            "target": "DocumentIdentification",
            "status": "selector",
            "reason": "Template/document id 1328."
          }
        ]
      },
      {
        "title": "Document envelope",
        "sourceGroup": "Document envelope",
        "targetType": "DocumentInformation",
        "targetPath": "DocumentInformation",
        "decision": "mapped",
        "description": "These fields identify the source company, brand, client, mediator, product, policy, document type, sequence, processing date, and print channel. They migrate to DocumentInformation because they describe the document envelope and routing context.",
        "rows": [
          {
            "source": "07 :PREFIX:-COMPANY PIC X(003).",
            "sourceField": "COMPANY",
            "target": "CompanyCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-MARCA PIC X(003).",
            "sourceField": "MARCA",
            "target": "BrandCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-CLIENT-REFERENCE PIC X(010).",
            "sourceField": "CLIENT-REFERENCE",
            "target": "ClientNumber",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-AGENTE-COBRADOR PIC X(010).",
            "sourceField": "AGENTE-COBRADOR",
            "target": "AgentNumber",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-PRODUTO PIC X(005).",
            "sourceField": "PRODUTO",
            "target": "ProductCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-POLICY-NUMBER PIC X(016).",
            "sourceField": "POLICY-NUMBER",
            "target": "PolicyNumber",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-POLICY-TRANSACTION PIC X(010).",
            "sourceField": "POLICY-TRANSACTION",
            "target": "PolicyTransactionCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TIPO-DOC PIC X(005).",
            "sourceField": "TIPO-DOC",
            "target": "DocumentTypeCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-NUM-SEQ-1 PIC 9(005).",
            "sourceField": "NUM-SEQ-1",
            "target": "OriginSequenceNumber",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-DATA-PROCESSAMENTO PIC X(008).",
            "sourceField": "DATA-PROCESSAMENTO",
            "target": "ProcessingDate",
            "status": "mapped"
          },
          {
            "source": "05 :PREFIX:-TIPO-IMPRESSAO PIC X(001).",
            "sourceField": "TIPO-IMPRESSAO",
            "target": "PrintType",
            "status": "mapped"
          },
          {
            "source": null,
            "target": "DocumentCode",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "UserId",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "OriginDocumentNumber",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "OriginSystemCode",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "FlyerIndicator",
            "status": "target-only"
          }
        ]
      },
      {
        "title": "Client entity",
        "sourceGroup": "Client / address",
        "targetType": "Entity",
        "targetPath": "Client",
        "decision": "mapped",
        "description": "BGOW9068 carries the client reference and destination name/address in the same payload. The client is represented as an Entity, with the address fields also available through the mailing address object.",
        "rows": [
          {
            "source": "07 :PREFIX:-CLIENT-REFERENCE PIC X(010).",
            "sourceField": "CLIENT-REFERENCE",
            "target": "Client.Reference",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-ADDRESSEE PIC X(040).",
            "sourceField": "TM-ADDRESSEE",
            "target": "Client.Name",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-POST-CODE PIC X(008).",
            "sourceField": "POST-CODE",
            "target": "Client.Address.PostalCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-ADDRESS1 PIC X(040).",
            "sourceField": "TM-ADDRESS1",
            "target": "Client.Address.Line1",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-ADDRESS2 PIC X(040).",
            "sourceField": "TM-ADDRESS2",
            "target": "Client.Address.Line2",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-ADDRESS3 PIC X(040).",
            "sourceField": "TM-ADDRESS3",
            "target": "Client.Address.Locality",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-ADDRESS4 PIC X(040).",
            "sourceField": "TM-ADDRESS4",
            "target": "Client.Address.PostalCodeDescription",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-TNUM-PORTA PIC X(001).",
            "sourceField": "TM-TNUM-PORTA",
            "target": "Client.Address.DoorTypeCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-NUM-PORTA PIC X(004).",
            "sourceField": "TM-NUM-PORTA",
            "target": "Client.Address.DoorIdentifier",
            "status": "mapped"
          },
          {
            "source": null,
            "target": "Client.Number",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Client.TaxIdentificationNumber",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Client.TypeCode and Client.Type",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Client.Contact",
            "status": "target-only"
          }
        ]
      },
      {
        "title": "Mediator entity",
        "sourceGroup": "Mediator",
        "targetType": "Entity?",
        "targetPath": "Agent",
        "decision": "mapped",
        "description": "The collecting agent/mediator fields are represented with the same Entity type used for other parties. The mediator is optional because some records may not provide mediator data.",
        "rows": [
          {
            "source": "07 :PREFIX:-AGENTE-COBRADOR PIC X(010).",
            "sourceField": "AGENTE-COBRADOR",
            "target": "Agent.Reference",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-AG-POST-CODE PIC X(008).",
            "sourceField": "AG-POST-CODE",
            "target": "Agent.Address.PostalCode",
            "status": "mapped"
          },
          {
            "source": null,
            "target": "Agent.Name",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Agent.Number",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Agent.Contact",
            "status": "target-only"
          }
        ]
      },
      {
        "title": "Mailing address",
        "sourceGroup": "Address",
        "targetType": "PostalAddress",
        "targetPath": "MailingAddress",
        "decision": "mapped",
        "description": "The TM address lines form the destination postal address used by the letter. The same source fields can also enrich the Client entity address.",
        "rows": [
          {
            "source": "07 :PREFIX:-TM-ADDRESSEE PIC X(040).",
            "sourceField": "TM-ADDRESSEE",
            "target": "MailingAddress.Name",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-ADDRESS1 PIC X(040).",
            "sourceField": "TM-ADDRESS1",
            "target": "MailingAddress.Line1",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-ADDRESS2 PIC X(040).",
            "sourceField": "TM-ADDRESS2",
            "target": "MailingAddress.Line2",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-ADDRESS3 PIC X(040).",
            "sourceField": "TM-ADDRESS3",
            "target": "MailingAddress.Locality",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-ADDRESS4 PIC X(040).",
            "sourceField": "TM-ADDRESS4",
            "target": "MailingAddress.PostalCodeDescription",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-POST-CODE PIC X(008).",
            "sourceField": "POST-CODE",
            "target": "MailingAddress.PostalCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-TNUM-PORTA PIC X(001).",
            "sourceField": "TM-TNUM-PORTA",
            "target": "MailingAddress.DoorTypeCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TM-NUM-PORTA PIC X(004).",
            "sourceField": "TM-NUM-PORTA",
            "target": "MailingAddress.DoorIdentifier",
            "status": "mapped"
          },
          {
            "source": null,
            "target": "MailingAddress.Reference",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "MailingAddress.Line3 / Line4",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "MailingAddress.CountryCode / CountryDescription",
            "status": "target-only"
          }
        ]
      },
      {
        "title": "Policy and product context",
        "sourceGroup": "Policy / product",
        "targetType": "Policy",
        "targetPath": "Policy",
        "decision": "mapped",
        "description": "The policy number, transaction, product code, and product description are grouped under Policy because they describe the insurance policy context of the contact-change letter.",
        "rows": [
          {
            "source": "07 :PREFIX:-POLICY-NUMBER PIC X(016).",
            "sourceField": "POLICY-NUMBER",
            "target": "Policy.Number",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-POLICY-TRANSACTION PIC X(010).",
            "sourceField": "POLICY-TRANSACTION",
            "target": "Policy.TransactionCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-PRODUTO PIC X(005).",
            "sourceField": "PRODUTO",
            "target": "Policy.Product.ProductCode",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-PRODUCT PIC X(030).",
            "sourceField": "PRODUCT",
            "target": "Policy.Product.BranchProductDescription",
            "status": "mapped"
          },
          {
            "source": null,
            "target": "Policy.Product.CurrencyCode",
            "status": "target-only"
          },
          {
            "source": null,
            "target": "Policy.Product.BranchCode",
            "status": "target-only"
          }
        ]
      },
      {
        "title": "Print payload control",
        "sourceGroup": "Print payload control",
        "targetType": "PrintPayloadRecordControl",
        "targetPath": "PrintRecordControl",
        "decision": "mapped",
        "description": "These fields describe the typed record within the printable payload. They move to PrintPayloadRecordControl instead of becoming business-domain fields.",
        "rows": [
          {
            "source": "07 :PREFIX:-NUM-SEQ-1 PIC 9(005).",
            "sourceField": "NUM-SEQ-1",
            "target": "SequenceNumber",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-RECORD-TYPE-1 PIC X(002).",
            "sourceField": "RECORD-TYPE-1",
            "target": "PrimaryRecordType",
            "status": "mapped"
          },
          {
            "source": "09 :PREFIX:-RECORD-TYPE-2 PIC X(001).",
            "sourceField": "RECORD-TYPE-2",
            "target": "SecondaryRecordType",
            "status": "mapped"
          },
          {
            "source": "07 :PREFIX:-TYPE-1-2.",
            "sourceField": "TYPE-1-2",
            "target": "CompositeRecordType",
            "status": "mapped"
          },
          {
            "source": "05 :PREFIX:-PRINT-DATA PIC X(413).",
            "sourceField": "PRINT-DATA",
            "target": "RawPrintData",
            "status": "mapped"
          }
        ]
      }
    ]
  }
];
