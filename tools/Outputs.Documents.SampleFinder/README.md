# Outputs.Documents.SampleFinder

Sample model discovery and catalog infrastructure.

This project does not contain actual document samples. Actual sample data lives beside the contract it constructs inside origin contract projects.

## What Lives Here

- `Samples/`
  - `IDocumentModelSample<TModel>`: implemented by concrete sample classes.
  - `IDocumentModelSampleCatalog`: runtime lookup abstraction.
  - `DocumentModelSampleDescriptor`: discovered sample metadata.
  - `DocumentModelSampleCatalog`: catalog for one scanned assembly.
  - `DocumentModelSampleCatalogCollection`: combines registered catalogs.
- `Registration/`
  - `DocumentModelSampleScanner`: discovers sample classes from an assembly.
  - `DocumentModelSampleServiceCollectionExtensions`: adds `.WithSamplesFromAssembly(...)`.

## What Does Not Live Here

Do not put sample data classes here.

Good location:

```text
origins/Outputs.Documents.DOCE.Contracts/
  DC000CoverPage/
    Samples/
      DefaultCoverPageSample.cs
```

The sample infrastructure stays generic, while the sample data stays close to the contract shape it validates.

## Rules

- Do not reference origin projects.
- Do not reference rendering, components, dashboard, or PDF providers.
- Keep sample discovery assembly-based.
- Keep sample classes simple data builders.
