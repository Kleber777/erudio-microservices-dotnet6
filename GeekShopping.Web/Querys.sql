-- Popular o carrinho
-- Entender o porque não tá chamando a página corretamente quando excluído o carrinho. 
-- Tá funcionando a deleção, mas entender o porque não passa o id. (x)
-- Tem o projeto da seção 15 dele para eu me basear. (sera o tipo diferente do parâmetro?)

-- Porque o meu consta o cart_header_id e o product_id
use geekshopping_cart_api; select * from cart_detail;

-- O valor antigo estava CartHeaderId = 1
use geekshopping_cart_api; select * from cart_header;
use geekshopping_cart_api; select * from product;
use geekshopping_cart_api; update cart_detail set cart_header_id = 5, product_id = 1 where id = 5;
use geekshopping_cart_api; update cart_detail set cart_header_id = 5, product_id = 3 where id = 6;


use geekshopping_productapi; select * from product;

--create database geekshopping_coupon_api
use geekshopping_coupon_api; select * from product;


-- geekshopping_order_api
	create database geekshopping_order_api; 
	use geekshopping_order_api; select * from order_detail;
	use geekshopping_order_api; select * from order_header;

