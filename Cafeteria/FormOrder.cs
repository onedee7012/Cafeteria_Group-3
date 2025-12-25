 void LoadCategory()
 {
     List<Category> listCategory = CategoryDAL.Instance.GetListCategory();
     cbmenu.DataSource = listCategory;
     cbmenu.DisplayMember = "Name";
 }

 void LoadBeverageListByCategoryID(int id)
 {
     List<Beverage> listBeverage = BeverageDAL.Instance.GetBeverageByCategoryID(id);
     cbbeverage.DataSource = listBeverage;
     cbbeverage.DisplayMember = "Name";
 }