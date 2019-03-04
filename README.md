# Directory sorter

This is a simple console application to automate me having to sort out various file dump spots on my computer. It sorts files based on extensions into various folders (I might have missed some valid extensions).

### Media sorting

Media sorting, sorts series and movies into said folders. Initially I wanted this to be done by making use of imdb api calls to check if x name was a movie or a series. This worked fine ([omdbapi](http://omdbapi.com)) but due to the fact that I can't generalize the naming conventions of files I download to get accurate response objects from the api, I swapped over to checking the length of the file (>90 minutes = movie, <90 minutes = series episode). 

* Note if files do not have a S02E01 or s02e02 in the file name it will not be placed into season folders but instead placed into the series\seriesName folder

#### Images
+ [Messy directory](https://imgur.com/sDEh1w5)
+ [Organised directory](https://imgur.com/OoZKf09)
