# Add Query paramater, do search and replace on *requestbuilder*.cs

``` 
//search for
public (datetimeoffset\??\[?\]?|bool\??\[?\]?|long\??\[?\]?|int\??\[?\]?|string\??\[?\]?|datetime\??\[?\]?|double\??\[?\]?)\s(\w+).{ get; set; }
// replace with:

[QueryParameter("$2")]\n\t\t\tpublic $1 $2 { get; set; }
```