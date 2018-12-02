# Letters

#### An MVC teaching/learning tool for myself

#### By Scott Bergler

## Description
Relearn/reframe MVC architecture and routing in a way that I can more easily understand.

### Processes:
INDEX ('home') :: Views/Home || Controllers/HomeControllers
```
[HttpGet("/")]
public ActionResult Index() { return View(); }
```

```
[TestMethod]
Index_ReturnsCorrectView_True()
```

NEW :: Views/Writer || Controllers/WriterControllers
```
[HttpGet("/classname/new")]
public ActionResult New() { return View(); }
```
```
[TestMethod]
New_ReturnsCorrectView_True()
```

CREATE :: Views/Writer || Controllers/WriterControllers
```
[HttpPost("/classname")]
public ActionResult New() { . . . return RedirectToAction("ActionName"); }
```
```
[TestMethod]
New_ReturnsCorrectActionResult_True()
```
```
TestMethod
New_RedirectsToCorrectActionName_True()
```
```
TestMethod
New_HasCorrectModelDatatype_True()
```

SHOW :: Views/Writer || Controllers/WriterControllers
```
[HttpGet("/classname/show")]
public ActionResult Index() { return View(); }
```
```
TestMethod
Index_ReturnsCorrectView_True()
```

## Setup/Installation Requirements
Clone the code from [GitHub](https://github.com/skillitzimberg/Letters.Solution).


## Known Bugs

## Support and contact details
Scott Bergler :: commandinghands@gmail.com

## Technologies Used

HTML, CSS, Json, C#.

### License

Licensed under the MIT license.

Copyright (c) 2018 ** Scott Bergler **
