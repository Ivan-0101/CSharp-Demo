using System;
class Problem2Class {
  public static void Main (string[] args) {

double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeigth = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeigth = double.Parse(Console.ReadLine());

double bathroomArea = bathroomWidth * bathroomHeigth;
double tileArea = tileWidth * tileHeigth;
double numberOfTiles = (bathroomArea / tileArea) * 0.1 + (bathroomArea / tileArea);

Console.WriteLine($"{numberOfTiles:F0}");
    }
  }



/*
git branch - Check which branch you're currently on (Local).
git branch -r - List all branches (Remote).
git branch -a - List all branches (Local + Remote).
git checkout branch-name – Switch to the desired branch.
git checkout -- name-of-the-file-to-discard - Discard changes of a file stopping you from switching between branches.
git stash --include-untracked - Save changes to a file (that you don't want to discard) stopping you from switching between branches.
git branch -D new-branch-name - Delete a branch.
git fetch --prune - Remove any branches that have been deleted on the remote server.
git add . - Add all files to the staging area.
git commit -m "message" – Commit your changes.
git push origin branch-name – Push to the specific remote branch.
*/