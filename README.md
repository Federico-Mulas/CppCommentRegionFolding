# Cpp Comment Region Folding

Porting of the original project 
Credits to original project project https://github.com/madskristensen/JavaScriptRegions
that adds support for region comments in C/C++ files.

Download this extension from the [VS Marketplace](https://marketplace.visualstudio.com/items?itemName=FedericoMulas.CppCommentRegionFolding)

## Features

- Region outlining/folding
- Snippet for inserting region

### Outlining
Creates collapsable regions in the C/C++ document using a pair of comments `// #region <region name>` and `// #endregion`

A example usage:

```c++
// #region Functions

void f();

void g();

// #endregion
```

### Snippet
A `region` snippet is provided in IntelliSense to make it easy to use regions in your code.

### Original project

Credits to original project project https://github.com/madskristensen/JavaScriptRegions

## License
[Apache 2.0](LICENSE)
