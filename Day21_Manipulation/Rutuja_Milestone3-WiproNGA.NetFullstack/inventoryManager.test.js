const InventoryManager = require('./inventoryManager');

test('Add product', () => {
    const inv = new InventoryManager();
    inv.addProduct({ productId: 1, name: "Phone", category: "Electronics", price: 500, stock: 10});
    expect(inv.products.length).toBe(1);
});

test('Get product by ID', () => {
    const inv = new InventoryManager();
    inv.addProduct({ productId: 1, name: "Phone", category: "Electronics", price: 500, stock: 10});
    expect(inv.getProductById(1).name).toBe("Phone");
});
test('Update product', () => {
    const inv = new InventoryManager();
    inv.addProduct({ productId: 1, name: "Phone", category: "Electronics", price: 500, stock: 10});
    inv.updateProduct(1, { price: 600});
    expect(inv.getProductById(1).price).toBe(600);
});

test('Delete product', () => {
    const inv = new InventoryManager();
    inv.addProduct({ productId: 1, name: "Phone", category: "Electronics", price: 500, stock: 10});
    inv.deleteProduct(1);
    expect(inv.products.length).toBe(0);
});