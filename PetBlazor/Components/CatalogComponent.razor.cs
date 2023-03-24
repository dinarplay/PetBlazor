using Microsoft.AspNetCore.Components;
using PetBlazor.Models;
using PetBlazor.Services;

namespace PetBlazor.Components
{
    public class CatalogModel : ComponentBase
    {
        [Inject]
        DbManagerService dbManagerService { get; set; }

        [Inject]
        NavigationManager navigationManager { get; set; }
                
        public List<Category> categs { get; set; }
        public List<Category> tempCategs { get; set; }


        public List<Manufacturer> manufs { get; set; }
        public List<Manufacturer> tempManufs { get; set; }

        public List<Product> prods { get; set; }
        public List<Product> tempProds { get; set; }

        public List<Bucket> buckets { get; set; }
        private Bucket bucket { get; set; }

        public string firstOption { get; set; }
        public string secondOption { get; set; }

        public bool nameCondition { get; set; }
        public bool categCondition { get; set; }
        public bool manufCondition { get; set; }
        public bool countCondition { get; set; }

        async protected override Task OnInitializedAsync()
        {
            firstOption = "All";
            secondOption = "All";

            prods = await dbManagerService.GetAllProducts();
            manufs = await dbManagerService.GetAllManufs();
            categs = await dbManagerService.GetAllCategs();

            tempProds = prods;
            tempManufs = manufs;
            tempCategs = categs;
        }
        public void Dispose()
        {
            //Dispose();
        }
        public void ShowCatalog(ChangeEventArgs e, bool whichSelect)
        {
            if (whichSelect)
            {
                firstOption = e.Value.ToString();
                secondOption = secondOption;
                if (firstOption == "All")
                {
                    if (secondOption == "All")
                    {
                        tempProds = prods.ToList();
                    }
                    else
                    {
                        tempProds = prods.Where(c => c.Manufacturer.Name == secondOption).ToList();
                    }
                    tempManufs = manufs;
                }
                else
                {
                    if (secondOption == "All")
                    {
                        tempProds = prods.Where(c => c.Category.Name == firstOption).ToList();
                    }
                    else
                    {
                        tempProds = prods.Where(c => c.Category.Name == firstOption && c.Manufacturer.Name == secondOption).ToList();
                    }
                    tempManufs = prods.Where(c => c.Category.Name == firstOption).Select(c => c.Manufacturer).Distinct().ToList();
                }
            }
            else
            {
                firstOption = firstOption;
                secondOption = e.Value.ToString();
                if (secondOption == "All")
                {
                    if (firstOption == "All")
                    {
                        tempProds = prods.ToList();
                    }
                    else
                    {
                        tempProds = prods.Where(c => c.Category.Name == firstOption).ToList();
                    }
                }
                else
                {
                    if (firstOption == "All")
                    {
                        tempProds = prods.Where(c => c.Manufacturer.Name == secondOption).ToList();
                    }
                    else
                    {
                        tempProds = prods.Where(c => c.Category.Name == firstOption && c.Manufacturer.Name == secondOption).ToList();
                    }
                    tempCategs = prods.Where(c => c.Manufacturer.Name == secondOption).Select(c => c.Category).Distinct().ToList();
                }
            }
        }
        /*ENTITY NOT DONE*/
        //async public void Buy()
        //{
        //    foreach (var item in tempProds.Where(c => c.Count > 0))
        //    {
        //        buckets = await dbManagerService.GetAllBuckets();
        //        bucket = buckets.Where(c => c.ProductId == item.Id).FirstOrDefault();
        //        if (bucket is null)
        //        {
        //            dbManagerService.AddToBucket(
        //                new Bucket
        //                {
        //                    Count = item.Count,
        //                    Product = item
        //                });
        //        }
        //        else
        //        {
        //            bucket.Count += item.Count;
        //            dbManagerService.ValueChanged(bucket);
        //        }
        //        item.Count = 0;
        //    }
        //}
        public void SortOfName()
        {
            if (nameCondition)
            {
                tempProds = tempProds.OrderBy(c => c.Name).ToList();
                nameCondition = !nameCondition;
            }
            else
            {
                tempProds = tempProds.OrderByDescending(c => c.Name).ToList();
                nameCondition = !nameCondition;
            }
        }
        public void SortOfManuf()
        {
            if (manufCondition)
            {
                tempProds = tempProds.OrderBy(c => c.Manufacturer.Name).ToList();
                manufCondition = !manufCondition;
            }
            else
            {
                tempProds = tempProds.OrderByDescending(c => c.Manufacturer.Name).ToList();
                manufCondition = !manufCondition;
            }
        }
        public void SortOfCategory()
        {
            if (categCondition)
            {
                tempProds = tempProds.OrderBy(c => c.Category.Name).ToList();
                categCondition = !categCondition;
            }
            else
            {
                tempProds = tempProds.OrderByDescending(c => c.Category.Name).ToList();
                categCondition = !categCondition;
            }
        }
        public void SortOfCount()
        {
            if (countCondition)
            {
                tempProds = tempProds.OrderBy(c => c.Count).ToList();
                countCondition = !countCondition;
            }
            else
            {
                tempProds = tempProds.OrderByDescending(c => c.Count).ToList();
                countCondition = !countCondition;
            }
        }
        public void ToBucket()
        {
            navigationManager.NavigateTo("/bucket");
        }
    }
}
