<?php

namespace Database\Seeders;

use App\Models\Admin;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class CreateAdminsSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        $admins = [
            [
                'name' => ' Admin',
                'email' => 'admin@odc.com',
                'password' => bcrypt('123456'),
            ],
        ];
        foreach ($admins as $key => $admin) {

            Admin::create($admin);
        }
    }
}