using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Hello, C#");

        Console.WriteLine("Softuni".Contains("uni"));

        for (int i = 1; i <= 100; i++)
            Console.Write(i + " ");

        Console.WriteLine();

        Console.WriteLine("Softuni".Contains("UNI"));
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
git add . - Add all files to the staging area.
git commit -m "message" – Commit your changes.
git push origin branch-name – Push to the specific remote branch.
*/