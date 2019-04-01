# Searchfight Challenge

To determine the popularity of programming languages on the internet we want to you to write an application that queries search engines and compares how many results they return, for example:

```
    C:\> searchfight.exe .net java

    .net: Google: 4450000000 MSN Search: 12354420
    java: Google: 966000000 MSN Search: 94381485
    Google winner: .net
    MSN Search winner: java
    Total winner: .net

```

## Rules

* The application should be able to receive a variable amount of words.
* The application should support quotation marks to allow searching for terms with spaces (e.g. searchfight.exe “java script”).
* The application should support at least two search engines.