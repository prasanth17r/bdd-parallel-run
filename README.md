# bdd-parallel-run
This repo is demonstrate capabilities and limitations of Specflow in terms of parallel execution

## Enabling parellelism
***
In the binding AmazonAppStepDefinitions.cs, find the "Parallelizable" attribute.

1) [assembly: Parallelizable(ParallelScope.Fixtures)] -> This enables parellel run of scenarios from multiple feature files. But not scenarios from a single feature file.

2) [assembly: Parallelizable(ParallelScope.All)] -> This enables parallel run of scenarios from a single feature but does not work as expected.
