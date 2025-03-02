using System;
class Problem3Class {
  public static void Main (string[] args) {

int countOfNegativeNumbers = 0;

for (int i = 0; i < 3; i++)
    {
      int num = int.Parse(Console.ReadLine());
      if (num < 0)
      {
        countOfNegativeNumbers++;
      }
    }
if (countOfNegativeNumbers % 2 != 0 && countOfNegativeNumbers != 0)
    {
      Console.WriteLine("negative");
    }
    else if (countOfNegativeNumbers % 2 == 0 && countOfNegativeNumbers != 0)
    {
      Console.WriteLine("positive");
    }
    else if (countOfNegativeNumbers == 0)
    {
      Console.WriteLine("zero");
    }
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