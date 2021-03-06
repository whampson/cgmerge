# CarGenTools
A set of tools for manipulating car generators in GTA savedata files.

## Supported Games
* *Grand Theft Auto III*
* *Grand Theft Auto: Vice City*

## The Tools
* `cgimport` - Imports car generators from a JSON file into a GTA savedata file.
* `cgmerge` - Combines car generators from one or more GTA savedata files into a single savedata file.

## Installation
### Install as .NET Core Tools (Recommended)
1) Download and install the [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core).
2) Open a shell and run the following to install each tool.
```
$ dotnet tool install -g CarGenImport
$ dotnet tool install -g CarGenMerge
```
3) Run `cgimport` or `cgmerge` from anywhere on your system.

### Standalone Installation
1) Download and extract the [latest standalone release](https://github.com/whampson/CarGenTools/releases)
for your system.
2) Open a shell and navigate to the extraction directory.
3) Run `cgimport` or `cgmerge`.

## Usage
### cgimport
```
$ cgimport --help
GTA Car Generator Import Tool
(C) 2020 thehambone

cgimport [options] savefile cargenfile

Imports car generators from a JSON file into a GTA3/VC savedata file.


  -r, --replace    Replace the entire car generator pool instead of individual items. Note: this
                   will overwrite all car generators.
  -t, --title      Set the in-game title of the savefile.
  -x, --export     Export car generators instead of importing. Ignores -r and -t.
  -g, --game       (Default: GTA3) Select the game to work with. Valid values: GTA3, VC
  -o, --output     Set the output file path.
  -v, --verbose    Enable verbose output for hackers.
  --help           Display this help screen.
  --version        Display version information.
```

### cgmerge
```
$ cgmerge --help
GTA Car Generator Merge Tool
(C) 2020 thehambone

cgmerge [options] target source...

Combines car generators from one or more GTA3/VC savedata files into a single savedata file. Merging
occurs by first comparing the car generators from each source file against the car generators in the
target file slot-by-slot, then replacing the differing car generators in the target file with car
generators from the source files. Car generators in the source files with the Model set to 0 are
ignored.


  -p, --priority-list    A CSV file specifying the order in which to replace car generators. The
                         columns are (priority,index) where 'priority' represents the replacement
                         order and 'index' specifies the index of a car generator in the target
                         save's car generator list. A priority of 0 is the highest priority and thus
                         the first to be replaced. A negative priority will exclude a row. If
                         multiple rows share the same priority, one of the rows will be chosen at
                         random until all rows have been chosen exactly once. Lines beginning with
                         '#' are treated as comments and ignored. If no priority list is specified,
                         car generators will be replaced at random.
  -r, --radius           (Default: 5) Set the collision radius. If two car generators are found
                         within the collision radius, the merge process will be aborted.
  -t, --title            Set the in-game title of the target savefile.
  -g, --game             (Default: GTA3) Select the game to work with. Valid values: GTA3, VC
  -o, --output           Set the output file path.
  -v, --verbose          Enable verbose output for hackers.
  --help                 Display this help screen.
  --version              Display version information.
```
