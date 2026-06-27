namespace Catalog.Api.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Categories, string Description, string ImageFile, decimal Price)
        : Icommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler (IDocumentSession documentSession) : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //business logic to create a product and return the result
            //save the database
            //return the CreateProductResult result
     
            var product =new Product
            {
                Name=command.Name,
                Categories= command.Categories,
                Description=command.Description,
                ImageFile=command.ImageFile,
                Price=command.Price

            };

            //save the product to the database

            documentSession.Store(product);
            await documentSession.SaveChangesAsync(cancellationToken);

            return new CreateProductResult(Guid.NewGuid());

          
        }
    }

}
