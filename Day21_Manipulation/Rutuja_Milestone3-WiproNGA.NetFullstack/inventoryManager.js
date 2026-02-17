class InventoryManager {
    constructor() {
        this.products = [];
    }
    addProduct(product) {
        if (this.products.find(p => p.productId === product.productId)) {
            throw new Error("Product already exists");
        }
        this.products.push(product);
    }
    getProductById(productId) {
        return this.products.find(p => p.productId === productId) || null;
    }
    
    updateProduct(productId, updates) {
        const product = this.getProductById(productId);
        if (!product) throw new Error("Product not found");

        Object.assign(product, updates);
    }
    deleteProduct(productId) {
        const index = this.products.findIndex(p => p.productId === productId);
        if (index === -1) throw new Error("Product not found");

        this.products.splice(index, 1);
    }
    listProducts() {
        return this.products;
    }
}
module.exports = InventoryManager;