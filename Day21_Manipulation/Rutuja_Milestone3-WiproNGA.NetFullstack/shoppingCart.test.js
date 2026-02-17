const ShoppingCart = require('./shoppingCart');

test('Add item to cart', () => {
    const cart = new ShoppingCart();
    cart.addItem("Book", 100, 2);
    expect(cart.items.length).toBe(1);
});

test('Remove item from cart', () => {
    const cart = new ShoppingCart();
    cart.addItem("Book", 100, 1);
    cart,removeItem("Book");
    expect(cart.items.length).toBe(0);
});

test('Calculate total', () => {
    const cart = new ShoppingCart();
    card.addItem("Book", 100, 2);
    expect(cart.calculateTotal()).toBe(200);
});

test('Apply discount', () => {
    const cart = new ShoppingCart();
    cart.addItem("Book", 100, 1);
    expect(cart.applyDiscount("SAVE10")).toBe(90);
});

test('Checkout clears cart', () => {
    const cart = new ShoppingCart();
    cart.addItem("Book", 100, 1);
    cart.checkout("SAVE10", 0.1);
    expect(cart.items.length).toBe(0);
});