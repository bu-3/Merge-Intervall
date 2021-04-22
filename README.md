# Merge-Intervall
A little desktop tool to merge overlapping intervals from a list into new intervals. The desktop tool provides a graphical user-interface to make it more fancy and easier to use.
![grafik](https://user-images.githubusercontent.com/40634763/115754320-60408980-a39c-11eb-9a9d-0d124cca10b1.png)

## How does it work
Entries within the list should look like this:
`[1,4][4,6][15,25][12,15][7,9][8,11]`

And the result from the list above would look like this:
`[1, 6][12, 25][7, 11]`

Here are some example files with 900, 20000 and 1,000,000 entries:
* [Merge-900.txt](https://github.com/bu-3/Merge-Intervall/files/6359866/Merge-900.txt)
* [Merge-20000.txt](https://github.com/bu-3/Merge-Intervall/files/6359868/Merge-20000.txt)

## Technical details
* C# only with Windows Forms
* IDE used: Visual Studio 2017
* Clone this Project, build and run it on Visual Studio
