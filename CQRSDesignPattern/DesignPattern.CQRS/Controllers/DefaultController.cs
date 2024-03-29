﻿using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler getProductQueryHandler;
        private readonly CreateProductCommandHandler createProductCommandHandler;
        private readonly GetProductByIdQueryHandler getProductByIdQueryHandler;
        private readonly DeleteProductCommandHandler deleteProductCommandHandler;
        private readonly GetProductUpdateByIdQueryHandler getProductUpdateByIdQueryHandler;
        private readonly UpdateProductCommandHandler updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetProductUpdateByIdQueryHandler getProductUpdateByIdQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            this.getProductQueryHandler = getProductQueryHandler;
            this.createProductCommandHandler = createProductCommandHandler;
            this.getProductByIdQueryHandler = getProductByIdQueryHandler;
            this.deleteProductCommandHandler = deleteProductCommandHandler;
            this.getProductUpdateByIdQueryHandler = getProductUpdateByIdQueryHandler;
            this.updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = getProductQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult GetProduct(int id)
        {
            var values = getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return View(values);
        }
        public IActionResult DeleteProduct(int id)
        {
            deleteProductCommandHandler.Handle(new DeleteProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = getProductUpdateByIdQueryHandler.Handle(new GetProductUpdateByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
