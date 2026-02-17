class ShoppingCart {
    constructor() {
        this.items = [];
    }

    addItem(name, price, quantity) {
        this.items.push({ name, price, quantity });
    }

    removeItem(name) {
        this.items = this.items.filter(item => item.name !==name);
    }
    calculateTotal() {
        return this.items.reduce((total, item) => total + item.price * item.quantity, 0);
    }
    applyDiscount(code) {
        const discounts = {
            SAVE10: 0.10,
            SAVE20: 0.20,
            SAVE30: 0.30
        };
        const discount = discounts[code] || 0;
        return this.calculateTotal() * (1-discount);
    }
    calculateTax(taxRate) {
        return this.calculateTotal() * taxRate;
    }
    checkout(discountCode, taxRate) {
        const discounted = this.applyDiscount(discountCode);
        const tax = this.calculateTax(taxRate);
        const finalAmount = discounted + tax;

        this.items = [];
        return finalAmount;
    }
}

module.exports = ShoppingCart;