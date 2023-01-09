<?php

namespace Database\Seeders;

use App\Models\User;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class CreateUsersSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        $users = [
            [
                'name' => ' User',
                'email' => 'user@odc.com',
                'password' => bcrypt('123456'),
            ],
        ];
        foreach ($users as $key => $user) {

            User::create($user);
        }
    }
}