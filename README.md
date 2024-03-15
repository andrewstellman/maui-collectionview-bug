# maui-collectionview-bug
Reproduce a .NET MAUI CollectionView bug -- see [.NET MAUI bug #21236](https://github.com/dotnet/maui/issues/21236)

### Description

The CollectionView control's ItemsUpdatingScrollMode does not seem to work on macOS (.NET 8.0.3). In this screenshot:

<img width="917" alt="image" src="https://github.com/dotnet/maui/assets/7516297/468c3feb-37aa-4e1a-be78-d8f53853ce12">

(screenshot from [maui-collectionview-bug repo](https://github.com/andrewstellman/maui-collectionview-bug/))

Clicking the button adds an item to the ObservableCollection that the CollectionView is bound to. The CollectionView has `ItemsUpdatingScrollMode="KeepLastItemInView"` set. I'm seeing two problems:

Problem 1: When running on Windows, when more items are added than fit in the view, it automatically scrolls to display the new item added. But when running on macOS, it does not automatically scroll, and seems to ignore the ItemsUpdatingScrollMode property.

Problem 2: When running on Windows, holding down control and clicking a selected item deselects it. On macOS, deselection does not seem to work when pressing option-click, control-click, or command-click.

Version info:

```
% dotnet workload list

Installed Workload Id      Manifest Version      Installation Source
--------------------------------------------------------------------
maui                       8.0.3/8.0.100         SDK 8.0.100        

Use `dotnet workload search` to find additional workloads to install.
```

### Steps to Reproduce

1. Add a CollectionView control to a page in a MAUI app and bind it to an ObservableCollection. Make sure it has the `ItemsUpdatingScrollMode="KeepLastItemInView"` and `HeightRequest="125"` properties.
2. Run the app in macOS and add a bunch of items to the ObservableCollection so there .

Expected: The CollectionView scrolls to keep the last item in view. 
Actual: The CollectionView does not scroll.

3. Click to select an item.
4. Control-click, option-click, or command-click to deselect the selected item.

Expected: The item is deselected
Actual: Nothing happens

Note that running in Windows returns the expected results, but running in macOS does not.

### Link to public reproduction project repository

https://github.com/andrewstellman/maui-collectionview-bug/

### Version with bug

8.0.3 GA

### Is this a regression from previous behavior?

Not sure, did not test other versions

### Last version that worked well

Unknown/Other

### Affected platforms

macOS

### Affected platform versions

_No response_

### Did you find any workaround?

Unfortunately, no.

### Relevant log output

_No response_
