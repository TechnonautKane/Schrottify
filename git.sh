#!/bin/bash

# Get the last commit message
last_commit_msg=$(git log -1 --pretty=format:%s)

# Print the last commit message
echo "Last commit message: $last_commit_msg"

# Prompt the user for a new commit message
read -p "Enter the new commit message: " new_commit_msg

# Add all changes to git
git add .

# Commit with the new commit message
git commit -m "$new_commit_msg"
