# WordFinder

## Analysis and evaluation
I sepparate the way to search in the matrix in two ways: horizontally and vertically. In the horizontal case, I search in the matrix by using Linq and Contains method beause the words appear from left to right. On the other hand, for the vertical case, I decided to transpose the matrix so I can seach the words that appear vertically by using the horizontal approach. As per, each word is searching in both ways I just iterate the list of words once.

## Testing
To be able to test the app, you just can run the app because there a matrix and a list of words already created (the same that the challenge description).
