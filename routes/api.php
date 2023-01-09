<?php

use App\Http\Controllers\AdminController;
use App\Http\Controllers\AuthController;
use App\Http\Controllers\SingerController;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

// Route::prefix('products')->controller(ProductController::class)->group(function () {
//     Route::middleware('auth:admin_api')->group(function () {
//         Route::post('/', 'store');
//         Route::post('update/{id}', 'update');
//         Route::delete('/{id}', 'delete');
//     });

//     Route::middleware('auth:customer_api')->group(function () {
//         Route::get('/', 'getAllProduct');
//         Route::get('/{id}', 'show');
//     });
// });


Route::prefix('admin')->controller(AdminController::class)->group(function () {

    Route::post('login', 'login');
    Route::post('register', 'register');
    Route::middleware('auth:admin')->group(function () {
        Route::post('logout', 'logout');
        Route::post('me', 'me');
    });
});

Route::prefix('user')->controller(AuthController::class)->group(function () {

    Route::post('login', 'login');
    Route::post('register', 'register');
    Route::middleware('auth:users_api')->group(function () {
        Route::post('logout', 'logout');
        Route::post('me', 'me');
    });
});
Route::prefix('singer')->controller(SingerController::class)->group(function () {

    Route::post('login', 'login');
    Route::post('register', 'register');
    Route::middleware('auth:singers_api')->group(function () {
        Route::post('logout', 'logout');
        Route::post('me', 'me');
    });
});




Route::middleware('auth:sanctum')->get('/user', function (Request $request) {
    return $request->user();
});