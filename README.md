# One Kick Heroes Academy — Superhero Database (PRG2782)

**Windows Forms C# application + Git & GitHub — Beginner-friendly README**

This README explains what this project does and gives very detailed, step‑by‑step instructions for **cloning the repository**, **creating branches**, **making commits**, and **creating pull requests**. It assumes you are using **Windows**, **Visual Studio** as the IDE, and **Git/GitHub** for version control.

---

## Project overview

A Windows Forms application (C#) to manage superhero trainee records for One Kick Heroes Academy. The app stores superheroes in a text file (e.g. `superheroes.txt`), calculates rank and threat level from exam scores, allows add/view/update/delete, and writes a `summary.txt` report. This project is the PRG2782 assignment and uses Git for version control.

---

## Prerequisites

Before you start, install the following:

* **Visual Studio 2022 (or later)** with the **.NET desktop development** workload / Windows Forms support.
* **Git** for Windows (Git Bash / Git CLI). Download from [https://git-scm.com](https://git-scm.com) if you don’t have it.
* A **GitHub account** (github.com). You will push your repository here.
* (Optional) **GitHub Desktop** or **Visual Studio's Git integration**, if you prefer GUIs.

Make sure Visual Studio can build Windows Forms projects. If the project targets a specific .NET version (check `Project Properties` -> `Target Framework`), install that framework or SDK if needed.


---

## Clone the repo (step-by-step)

You will clone the remote GitHub repository to your local machine. You can use **HTTPS** or **SSH**.

### 1) Get the repository URL from GitHub

On the GitHub repo page, click the **Code** button and copy the HTTPS URL (looks like `https://github.com/USERNAME/REPO.git`) or the SSH URL.

### 2) Open Git Bash, PowerShell or Windows Terminal

Navigate to a folder where you want the project stored, for example, `C:\Users\YourName\Source\`:

```bash
cd C:/Users/YourName/Source/
```

### 3) Clone the repository

Use the copied URL in the command below (replace `URL`):

```bash
git clone URL
# example:
# git clone https://github.com/YourName/OneKickHeroes.git
```

This will create a new folder `OneKickHeroes` (or the repo name). Then go into it:

```bash
cd OneKickHeroes
```

### 4) Configure Git if this is your first time

Set your name and email (only needs to be done once per machine):

```bash
git config --global user.name "Your Name"
git config --global user.email "you@example.com"
```

You can check remote:

```bash
git remote -v
```

If you get authentication errors later when pushing, see the Troubleshooting section below (SSH vs HTTPS vs PAT).

---

## Work flow: branches, commits, pushes (command line)

This section shows the **basic Git workflow** for making a change and creating a pull request. We use a **feature-branch** workflow (recommended for beginners).

### 1) Make sure you are on `main` and up to date

```bash
git checkout main
git pull origin main
```

### 2) Create a new branch for your work

Name branches clearly, e.g. `feature/add-superhero`, `fix/validation`, or `docs/readme`:

```bash
git checkout -b feature/add-superhero
# -b creates and switches to the new branch
```

### 3) Work in Visual Studio

Open the solution in Visual Studio and implement your change (UI, code, tests).

### 4) See what changed and stage files

```bash
git status
# to stage specific files:
git add path/to/file.cs
# or to stage all changed files:
git add .
```

### 5) Commit your changes

Write a meaningful commit message. Keep messages short, prefixed with a type (optional): `feat:`, `fix:`, `docs:`.

```bash
git commit -m "feat: add AddSuperheroForm and save to superheroes.txt"
```

### 6) Push the branch to GitHub

```bash
git push -u origin feature/add-superhero
# -u sets the upstream so future 'git push' works without extra args
```

### 7) Open a Pull Request (PR) on GitHub (next section) to merge your branch into `main`.

---

## Pull requests (how to open a PR on GitHub)

Once your branch is pushed, open a PR to merge it into `main`.

1. Go to the repository page on GitHub.
2. You will usually see a **Compare & pull request** button for your recently pushed branch — click it. If not: click the **Pull requests** tab → **New pull request** → choose `base: main` and `compare: your-branch`.
3. Fill in the **title** and **description**. Explain what you changed and why. Reference issues if applicable (e.g. `Fixes #12`).
4. Add reviewers (team members), a label, or an assignee if your team uses them.
5. Click **Create pull request**.
6. Reviewers will comment/approve. If changes are requested, make them locally on the same branch, commit, and `git push` — the PR updates automatically.
7. After approval, merge the PR: click **Merge pull request** → **Confirm merge**. You may be asked to choose a merge method (create a merge commit, squash, or rebase). For beginners, using **Merge** (create a merge commit) is simplest.
8. Optionally delete your feature branch on GitHub after merging (there is a button shown after the merge).

### Command-line alternative to create a PR using `gh` (GitHub CLI)

If you have the GitHub CLI installed and authenticated, you can run:

```bash
gh pr create --base main --head yourUsername:feature/add-superhero --title "Add AddSuperheroForm" --body "Implements add superhero form and saving to file"
```

(You can skip this if you prefer the web UI.)

---

## Using Visual Studio's Git integration (GUI steps)

If you prefer the Visual Studio GUI, here are step-by-step instructions:

1. **Clone**: In Visual Studio, go to **Git** → **Clone Repository** → paste the repo URL → **Clone**.
2. **Open the solution**: double-click the `.sln` file in Solution Explorer.
3. **Create a branch**: In the top-right Git widget, click the branch name (e.g. `main`) → **New Branch** → enter `feature/add-superhero` → **Create Branch**.
4. **Make changes**: Edit forms and code as needed.
5. **Commit**: Open **Git Changes** (View → Git Changes). Stage the files you want (click the `+` next to files) and write a commit message, then click **Commit All** (or **Commit Staged**).
6. **Push**: After commit, click **Push** in the Git Changes pane or the Git widget (Push will upload the branch to remote).
7. **Create PR**: Visual Studio often shows a **Create Pull Request** link after pushing — click it to open a PR in the browser. Or open the PR from GitHub.
8. **Syncing**: To get upstream changes, use **Fetch** or **Pull** from the Git menu.

Visual Studio will show conflict markers and help you resolve conflicts via the merge editor when they occur.

## Clone the repo (GitHub Desktop method)

1. **Install GitHub Desktop** ([https://desktop.github.com](https://desktop.github.com)).
2. **Sign in** with your GitHub account.
3. Click **File → Clone Repository**.
4. Choose the **URL** tab and paste the GitHub URL of the project.
5. Select a local path (e.g., `C:\Users\YourName\Source\Repos\`).
6. Click **Clone**.
7. When done, click **Open in Visual Studio** to open the project directly.

---

## Work flow: branches, commits, pushes (command line)

1. Ensure you are on main:

   ```bash
   git checkout main
   git pull origin main
   ```
2. Create and switch to a new branch:

   ```bash
   git checkout -b feature/add-superhero
   ```
3. Make code changes in Visual Studio.
4. Stage and commit changes:

   ```bash
   git add .
   git commit -m "feat: add AddHeroForm and save to superheroes.txt"
   ```
5. Push branch to GitHub:

   ```bash
   git push -u origin feature/add-superhero
   ```

---

## Work flow: branches, commits, pushes (GitHub Desktop)

1. Open **GitHub Desktop**.
2. Select your repository.
3. Switch branch: Click **Current Branch → New Branch**.
4. Type your branch name (e.g., `feature/add-superhero`) → click **Create Branch**.
5. Open Visual Studio, make your code changes.
6. Save all files, return to GitHub Desktop.
7. GitHub Desktop will show your changes. Write a **summary message** and **description**.
8. Click **Commit to feature/add-superhero**.
9. Click **Push origin** to upload to GitHub.
10. Click **Create Pull Request** (opens browser for next step).

---

## Pull requests (how to open a PR on GitHub)

1. Go to GitHub repository.
2. Click **Compare & pull request**.
3. Confirm base = `main`, compare = your branch.
4. Add title and description → click **Create pull request**.
5. After review and approval → click **Merge pull request** → **Confirm merge**.
6. Delete branch after merge (optional).

---

---

## Running the app in Visual Studio

1. Open the `.sln` file (File → Open → Project/Solution).
2. Ensure the correct project is set as the **Startup Project** (right-click project → `Set as Startup Project`).
3. Build the solution: **Build** → **Build Solution** (or `Ctrl+Shift+B`).
4. Run (debug): press **F5** to start with the debugger, or **Ctrl+F5** to run without debugging.
5. The application window should appear. Use the Add / View / Update / Delete UI to manage heroes.

If the app tries to read or write `superheroes.txt` and can't find it, it will usually create it automatically in the program working directory (commonly `bin/Debug/netX/`).

---

## Troubleshooting

* **Push error:** use Personal Access Token or SSH key.
* **Missing .NET:** install correct framework.
* **File errors:** ensure `superheroes.txt` exists or check permissions.

---

## Git command cheat sheet

```bash
git status
git add .
git commit -m "message"
git push -u origin branchname
git pull origin main
git checkout main
git merge branchname
```

---

## Commit message tips

Use short, descriptive messages:

* `feat:` for new features
* `fix:` for bug fixes
* `docs:` for documentation
* `refactor:` for code structure changes

---

## Collaboration workflow

1. Pull latest main.
2. Create feature branch.
3. Code → Commit → Push.
4. Create PR → Review → Merge.

---

## License / Credits

Created for PRG2782 project (One Kick Heroes Academy). Educational use only. Add a LICENSE file if needed.

---

This guide now covers **command-line**, **Visual Studio**, and **GitHub Desktop** workflows so beginners can confidently use any version control interface.
