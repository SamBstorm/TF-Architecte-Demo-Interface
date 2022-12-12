using TF_Architecte_Demo_Interface.Models;


List<IUser> users= new List<IUser>();
users.Add(new User() { UserName = "Admin", Password = "1234", Role = EnumRole.Admin });
users.Add(new User() { UserName = "SamFaitRire", Password = "1234", Role = EnumRole.User });

Article art1 = new Article() { Title = "Le C# avance!", Content = "Le .net est passé en version 7.0! Mettez-vous à jour...", Autor = (IAdmin)users[0] };

List<Article> MainContent = new List<Article>();
MainContent.Add(art1);

foreach(IUser user in users)
{
    if(user.Role == EnumRole.Admin)
    {
        IAdmin admin = (IAdmin) user;
        MainContent.Add(admin.WriteArticle());
    }
}


users[0].ReadArticle(MainContent[0]);
users[1].ReadArticle(MainContent[1]);
