Solution sol = new Solution();

string[] strs = new string[]
{
    "()[]{}",
    "{[]}",
    "]"
};
foreach(var item in strs)
{
    sol.IsValid(item);
}
